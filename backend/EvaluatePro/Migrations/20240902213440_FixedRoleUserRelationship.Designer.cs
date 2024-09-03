﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EvaluatePro.Migrations
{
    [DbContext(typeof(EvaluateProDbContext))]
    [Migration("20240902213440_FixedRoleUserRelationship")]
    partial class FixedRoleUserRelationship
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("Authentication", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Expiration")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("IsRevoked")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Token")
                        .HasColumnType("longtext");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("Authentication");
                });

            modelBuilder.Entity("Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CommentId")
                        .HasColumnType("int");

                    b.Property<string>("ConventionId")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("ScoreId")
                        .HasColumnType("int");

                    b.Property<int>("SubmissionId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CommentId")
                        .IsUnique();

                    b.HasIndex("ScoreId");

                    b.HasIndex("SubmissionId");

                    b.HasIndex("UserId");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("CommentType")
                        .HasColumnType("tinyint(1)");

                    b.Property<int?>("SubmissionId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SubmissionId");

                    b.ToTable("Comment");
                });

            modelBuilder.Entity("Convention", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<int>("CommentID")
                        .HasColumnType("int");

                    b.Property<string>("ConventionId")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("FeedbackId")
                        .HasColumnType("int");

                    b.Property<int>("ScoreId")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("CommentID")
                        .IsUnique();

                    b.HasIndex("ScoreId");

                    b.ToTable("Convention");
                });

            modelBuilder.Entity("Feedback", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ConventionId")
                        .HasColumnType("int");

                    b.Property<string>("FeedbackId")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<long>("Feedbacktext")
                        .HasColumnType("bigint");

                    b.Property<int>("ScoreId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ConventionId");

                    b.HasIndex("ScoreId");

                    b.ToTable("Feedback");
                });

            modelBuilder.Entity("Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Role");
                });

            modelBuilder.Entity("Score", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<int>("ConventionId")
                        .HasColumnType("int");

                    b.Property<int>("ScoreId")
                        .HasColumnType("int");

                    b.Property<int>("SubmissionId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Score");
                });

            modelBuilder.Entity("ScoreSubmission", b =>
                {
                    b.Property<int>("ScoresId")
                        .HasColumnType("int");

                    b.Property<int>("SubmissionsId")
                        .HasColumnType("int");

                    b.HasKey("ScoresId", "SubmissionsId");

                    b.HasIndex("SubmissionsId");

                    b.ToTable("ScoreSubmission");
                });

            modelBuilder.Entity("Submission", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<bool?>("IsDraft")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("ReceiverId")
                        .HasColumnType("int");

                    b.Property<int>("RoleCheck")
                        .HasColumnType("int");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<int>("Score")
                        .HasColumnType("int");

                    b.Property<int>("SubmissionComment")
                        .HasColumnType("int");

                    b.Property<int>("SubmitterId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.HasIndex("UserId");

                    b.ToTable("Submission");
                });

            modelBuilder.Entity("User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("BirthDay")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<bool>("IsActive")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("varchar(1)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<string>("SupervisiorName")
                        .HasColumnType("longtext");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("User");
                });

            modelBuilder.Entity("Authentication", b =>
                {
                    b.HasOne("User", "User")
                        .WithOne("Authentication")
                        .HasForeignKey("Authentication", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Category", b =>
                {
                    b.HasOne("Comment", "Comment")
                        .WithOne("Category")
                        .HasForeignKey("Category", "CommentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Score", "Score")
                        .WithMany("Categories")
                        .HasForeignKey("ScoreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Submission", "Submission")
                        .WithMany("Categories")
                        .HasForeignKey("SubmissionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Comment");

                    b.Navigation("Score");

                    b.Navigation("Submission");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Comment", b =>
                {
                    b.HasOne("Submission", "Submission")
                        .WithMany("Comments")
                        .HasForeignKey("SubmissionId");

                    b.Navigation("Submission");
                });

            modelBuilder.Entity("Convention", b =>
                {
                    b.HasOne("Category", "Category")
                        .WithMany("Conventions")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Comment", "Comment")
                        .WithOne("Convention")
                        .HasForeignKey("Convention", "CommentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Score", "Score")
                        .WithMany("Conventions")
                        .HasForeignKey("ScoreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Comment");

                    b.Navigation("Score");
                });

            modelBuilder.Entity("Feedback", b =>
                {
                    b.HasOne("Convention", "Convention")
                        .WithMany("Feedbacks")
                        .HasForeignKey("ConventionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Score", "Score")
                        .WithMany("Feedbacks")
                        .HasForeignKey("ScoreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Convention");

                    b.Navigation("Score");
                });

            modelBuilder.Entity("ScoreSubmission", b =>
                {
                    b.HasOne("Score", null)
                        .WithMany()
                        .HasForeignKey("ScoresId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Submission", null)
                        .WithMany()
                        .HasForeignKey("SubmissionsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Submission", b =>
                {
                    b.HasOne("Role", "Role")
                        .WithMany("Submissions")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("User", "User")
                        .WithMany("Submissions")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");

                    b.Navigation("User");
                });

            modelBuilder.Entity("User", b =>
                {
                    b.HasOne("Role", "Role")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("Category", b =>
                {
                    b.Navigation("Conventions");
                });

            modelBuilder.Entity("Comment", b =>
                {
                    b.Navigation("Category");

                    b.Navigation("Convention");
                });

            modelBuilder.Entity("Convention", b =>
                {
                    b.Navigation("Feedbacks");
                });

            modelBuilder.Entity("Role", b =>
                {
                    b.Navigation("Submissions");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("Score", b =>
                {
                    b.Navigation("Categories");

                    b.Navigation("Conventions");

                    b.Navigation("Feedbacks");
                });

            modelBuilder.Entity("Submission", b =>
                {
                    b.Navigation("Categories");

                    b.Navigation("Comments");
                });

            modelBuilder.Entity("User", b =>
                {
                    b.Navigation("Authentication");

                    b.Navigation("Submissions");
                });
#pragma warning restore 612, 618
        }
    }
}
