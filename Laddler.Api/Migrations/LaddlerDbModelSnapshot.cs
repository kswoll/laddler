﻿// <auto-generated />
using System;
using Laddler.Api.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Laddler.Api.Migrations
{
    [DbContext(typeof(LaddlerDb))]
    partial class LaddlerDbModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.3-rtm-32065")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Laddler.Api.Database.DbDimension", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<int>("DimensionGroupId");

                    b.Property<int>("LadderId");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("DimensionGroupId");

                    b.HasIndex("LadderId");

                    b.ToTable("Dimensions");
                });

            modelBuilder.Entity("Laddler.Api.Database.DbDimensionGroup", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("DimensionGroups");
                });

            modelBuilder.Entity("Laddler.Api.Database.DbDimensionMilestone", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<int>("DimensionId");

                    b.Property<int>("MilestoneId");

                    b.HasKey("Id");

                    b.HasIndex("DimensionId");

                    b.HasIndex("MilestoneId");

                    b.ToTable("DimensionMilestones");
                });

            modelBuilder.Entity("Laddler.Api.Database.DbLadder", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Ladders");
                });

            modelBuilder.Entity("Laddler.Api.Database.DbLevel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Rank");

                    b.Property<int>("RequiredPoints");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.ToTable("Levels");
                });

            modelBuilder.Entity("Laddler.Api.Database.DbMilestone", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.Property<int>("Points");

                    b.Property<int>("Rank");

                    b.HasKey("Id");

                    b.ToTable("Milestones");
                });

            modelBuilder.Entity("Laddler.Api.Database.DbPerson", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.HasKey("Id");

                    b.ToTable("Persons");
                });

            modelBuilder.Entity("Laddler.Api.Database.DbPersonDimension", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("DimensionMilestoneId");

                    b.Property<int>("PersonLadderId");

                    b.HasKey("Id");

                    b.HasIndex("DimensionMilestoneId");

                    b.HasIndex("PersonLadderId");

                    b.ToTable("PersonDimensions");
                });

            modelBuilder.Entity("Laddler.Api.Database.DbPersonLadder", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("LadderId");

                    b.Property<int>("PersonId");

                    b.HasKey("Id");

                    b.HasIndex("LadderId");

                    b.HasIndex("PersonId");

                    b.ToTable("PersonLadders");
                });

            modelBuilder.Entity("Laddler.Api.Database.DbUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("PasswordHash");

                    b.Property<int>("PersonId");

                    b.HasKey("Id");

                    b.HasIndex("PersonId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Laddler.Api.Database.DbDimension", b =>
                {
                    b.HasOne("Laddler.Api.Database.DbDimensionGroup", "DimensionGroup")
                        .WithMany()
                        .HasForeignKey("DimensionGroupId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Laddler.Api.Database.DbLadder", "Ladder")
                        .WithMany()
                        .HasForeignKey("LadderId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Laddler.Api.Database.DbDimensionMilestone", b =>
                {
                    b.HasOne("Laddler.Api.Database.DbDimension", "Dimension")
                        .WithMany("DimensionMilestones")
                        .HasForeignKey("DimensionId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Laddler.Api.Database.DbMilestone", "Milestone")
                        .WithMany("DimensionMilestones")
                        .HasForeignKey("MilestoneId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Laddler.Api.Database.DbPersonDimension", b =>
                {
                    b.HasOne("Laddler.Api.Database.DbDimensionMilestone", "DimensionMilestone")
                        .WithMany()
                        .HasForeignKey("DimensionMilestoneId");

                    b.HasOne("Laddler.Api.Database.DbPersonLadder", "PersonLadder")
                        .WithMany()
                        .HasForeignKey("PersonLadderId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Laddler.Api.Database.DbPersonLadder", b =>
                {
                    b.HasOne("Laddler.Api.Database.DbLadder", "Ladder")
                        .WithMany("PersonLadders")
                        .HasForeignKey("LadderId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Laddler.Api.Database.DbPerson", "Person")
                        .WithMany("PersonLadders")
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Laddler.Api.Database.DbUser", b =>
                {
                    b.HasOne("Laddler.Api.Database.DbPerson", "Person")
                        .WithMany()
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
