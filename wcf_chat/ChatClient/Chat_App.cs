using ChatContext.Context;
using ChatContext.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace ChatClient
{
	public class Chat_App
	{
		private ChatDB_Context chatDBContext = new ChatDB_Context(ConfigurationManager.ConnectionStrings["ChatDB_ConnectionString"].ConnectionString);

		public void AddContact(string name, string surname, string phone, string login, string password)
		{
			Contact contact = new Contact()
			{
				Name = name,
				Surname = surname,
				Phone = phone,
				Login = login,
				Password = password
			};

			chatDBContext.Contacts.Add(contact);
		}

		public void RemoveContact(Contact contact)
		{
			chatDBContext.Contacts.Remove(contact);
		}

		public Contact GetContact(string login, string password, string phone)
		{
			chatDBContext.Contacts.Load();
			return chatDBContext.Contacts.Local.FirstOrDefault(t => t.Login == login && t.Password == password && t.Phone == phone);
		}

		public Contact GetContact(string login, string password)
		{
			chatDBContext.Contacts.Load();
			return chatDBContext.Contacts.Local.FirstOrDefault(t => t.Login == login && t.Password == password);
		}

		public void SentMessage(Contact contact, string content, DateTime date)
		{
			Message message = new Message()
			{
				Content = content,
				SendDateTime = date,
			};

			chatDBContext.Contacts.Load();
			contact.Messages.Add(message);

			chatDBContext.SaveChanges();
		}

		public async Task<int> SaveAllChanges(Button sender)
		{
			sender.IsEnabled = false;
			try
			{
				return await chatDBContext.SaveChangesAsync();
			}
			finally
			{
				sender.IsEnabled = true;
			}
		}

		public bool IsThereContactAlready(string login, string password, string phone)
		{
			chatDBContext.Contacts.Load();
			return chatDBContext.Contacts.Local.Any(t => t.Login == login || t.Password == password || t.Phone == phone);
		}
	}
}
