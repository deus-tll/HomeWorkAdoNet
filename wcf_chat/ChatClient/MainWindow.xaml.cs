using System;
using System.Collections.Generic;
using System.Configuration;
using System.Windows;
using System.Windows.Input;
using ChatClient.ServiceChat;
using ChatContext.Context;
using ChatContext.Models;

namespace ChatClient
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window, IServiceChatCallback
	{
		//ЩОБ ПРОЕКТ ЗАПУСТИВСЯ ПРАВИЛЬНО, ПОТРІБНО СПОЧАТКУ ЗАПУСТИТИ ПРОЄКТ "ChatHost" ВІД ІМЕНІ АДМІНІСТРАТОРА,
		//А ПОТІМ ВЖЕ "ChatClient"(можна вже не від імені адміністратора)
		//також вибачаюсь за трохи брудний код, спішив просто

		private readonly Chat_App _app = new Chat_App();
		private bool isConnected = false;
		private ServiceChatClient client;
		private Contact contact;
		private int ID;


		public MainWindow()
		{
			InitializeComponent();
		}

		private void ConnectUser()
		{
			if (!isConnected)
			{
				contact = _app.GetContact(tbUserName.Text, tbPassword.Password);
				if (contact == null )
				{
					MessageBox.Show("Невірний логін або пароль!");
					return;
				}

				client = new ServiceChatClient(new System.ServiceModel.InstanceContext(this));
				ID = client.Connect(tbUserName.Text);

				tbUserName.IsEnabled= false;
				btnConDiscon.Content = "Disconnect";
				isConnected = true;
			}
		}

		private void DisconnectUser()
		{
			if (isConnected)
			{
				client.Disconnect(ID);
				client = null;

				tbUserName.IsEnabled = true;
				btnConDiscon.Content = "Connect";
				isConnected = false;
			}
		}

		private void btnConDiscon_Click(object sender, RoutedEventArgs e)
		{
			if (isConnected)
			{
				DisconnectUser();
			}
			else
			{
				ConnectUser();
			}
		}

		public void MsgCallBack(string msg)
		{
			lbChat.Items.Add(msg);
			lbChat.ScrollIntoView(lbChat.Items[lbChat.Items.Count - 1]);
		}

		private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			DisconnectUser();
		}

		private void tbMessage_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
		{
			if (e.Key == Key.Enter)
			{
				if (client != null)
				{
					client.SendMsg(tbMessage.Text, ID);

					_app.SentMessage(contact, tbMessage.Text, DateTime.Now);

					tbMessage.Text = string.Empty;
				}
			}
		}

		private static bool CheckFields(List<string> fields)
		{
			foreach (var field in fields)
			{
				if (string.IsNullOrEmpty(field))
				{
					MessageBox.Show("Всі поля мають бути заповнені!");
					return false;
				}
			}

			return true;
		}

		private bool ValidationContact()
		{
			List<string> fields = new List<string>()
			{
				TextBox_ContactName.Text,
				TextBox_ContactSurname.Text,
				TextBox_ContactPhone.Text,
				TextBox_ContactLogin.Text,
				TextBox_ContactPassword.Password
			};

			if (!CheckFields(fields)) return false;

			return true;
		}

		private async void Btn_AddContact_Click(object sender, RoutedEventArgs e)
		{
			if (!ValidationContact()) return;

			if(_app.IsThereContactAlready(TextBox_ContactLogin.Text, TextBox_ContactPassword.Password, TextBox_ContactPhone.Text))
			{
				MessageBox.Show("Такий контакт вже є\nТакі поля як: логін, пароль і телефон\nповинні бути унікальні");
				return;
			}

			_app.AddContact(TextBox_ContactName.Text,
				TextBox_ContactSurname.Text, 
				TextBox_ContactPhone.Text, 
				TextBox_ContactLogin.Text,
				TextBox_ContactPassword.Password);
			
			await _app.SaveAllChanges(Btn_AddContact);

			MessageBox.Show("Контакт було успішно зареєстровано!");
		}

		private async void Btn_RemoveContact_Click(object sender, RoutedEventArgs e)
		{
			List<string> fields = new List<string>()
			{
				TextBox_ContactLogin.Text,
				TextBox_ContactPassword.Password,
				TextBox_ContactPhone.Text
			};

			if (!CheckFields(fields))
				return;

			Contact contact = _app.GetContact(TextBox_ContactLogin.Text, TextBox_ContactPassword.Password, TextBox_ContactPhone.Text);
			if (contact == null) return;

			MessageBoxResult result = MessageBox.Show("Видалити контакт?", "Підтвердити...", MessageBoxButton.YesNo, MessageBoxImage.Question);
			if (result != MessageBoxResult.Yes) return;

			_app.RemoveContact(contact);

			await _app.SaveAllChanges(Btn_RemoveContact);

			MessageBox.Show("Контакт було успішно видалено!");
		}
	}
}
