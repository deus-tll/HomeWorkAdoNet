﻿// <auto-generated />
using Championship_DatabaseContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Championship_DatabaseContext.Migrations
{
    [DbContext(typeof(ChampionshipDB))]
    partial class ChampionshipDBModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Championship_Models.Models.Team", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<int>("NumberOfDefeats")
                        .HasColumnType("int");

                    b.Property<int>("NumberOfDraws")
                        .HasColumnType("int");

                    b.Property<int>("NumberOfGoalsScored")
                        .HasColumnType("int");

                    b.Property<int>("NumberOfMissedGoals")
                        .HasColumnType("int");

                    b.Property<int>("NumberOfWins")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Teams");
                });
#pragma warning restore 612, 618
        }
    }
}
