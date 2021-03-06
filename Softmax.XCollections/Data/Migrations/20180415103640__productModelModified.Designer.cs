﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using Softmax.XCollections.Data;
using Softmax.XCollections.Data.Enums;
using System;

namespace Softmax.XCollections.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20180415103640__productModelModified")]
    partial class _productModelModified
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Softmax.XCollections.Data.Entities.Branch", b =>
                {
                    b.Property<string>("BranchId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address");

                    b.Property<string>("BranchCode");

                    b.Property<string>("City");

                    b.Property<DateTime>("DateCreated");

                    b.Property<bool>("IsActive");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("Location");

                    b.Property<int>("StateCode");

                    b.HasKey("BranchId");

                    b.ToTable("Branches");
                });

            modelBuilder.Entity("Softmax.XCollections.Data.Entities.Customer", b =>
                {
                    b.Property<string>("CustomerId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AspNetUsersId");

                    b.Property<string>("Remarks");

                    b.HasKey("CustomerId");

                    b.HasIndex("AspNetUsersId");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("Softmax.XCollections.Data.Entities.Deposit", b =>
                {
                    b.Property<string>("DepositId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Amount");

                    b.Property<string>("ApplicationUserId");

                    b.Property<int>("Balance");

                    b.Property<string>("CustomerId");

                    b.Property<DateTime>("DateCreated");

                    b.Property<string>("EmployeeId");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("ProductId");

                    b.Property<string>("Reference");

                    b.Property<int>("StatusCode");

                    b.Property<int>("TransactionCode");

                    b.HasKey("DepositId");

                    b.HasIndex("ApplicationUserId");

                    b.HasIndex("CustomerId");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("ProductId");

                    b.ToTable("Deposits");
                });

            modelBuilder.Entity("Softmax.XCollections.Data.Entities.DepositConfirm", b =>
                {
                    b.Property<string>("DepositConfirmId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CustomerId");

                    b.Property<DateTime>("DateCreated");

                    b.Property<string>("DepositId");

                    b.Property<string>("EmployeeId");

                    b.HasKey("DepositConfirmId");

                    b.HasIndex("CustomerId");

                    b.HasIndex("DepositId");

                    b.HasIndex("EmployeeId");

                    b.ToTable("DepositConfirms");
                });

            modelBuilder.Entity("Softmax.XCollections.Data.Entities.Employee", b =>
                {
                    b.Property<string>("EmployeeId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AspNetUsersId");

                    b.Property<DateTime?>("Employment");

                    b.Property<DateTime?>("Termination");

                    b.HasKey("EmployeeId");

                    b.HasIndex("AspNetUsersId");

                    b.ToTable("Employee");
                });

            modelBuilder.Entity("Softmax.XCollections.Data.Entities.Loan", b =>
                {
                    b.Property<string>("LoanId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Amount");

                    b.Property<string>("ApplicationUserId");

                    b.Property<string>("CustomerId");

                    b.Property<DateTime?>("DateApproved");

                    b.Property<DateTime?>("DateCreated");

                    b.Property<DateTime?>("DueDate");

                    b.Property<string>("EmployeeId");

                    b.Property<int>("Interest");

                    b.Property<bool>("IsActive");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("ProductId");

                    b.Property<string>("Reference");

                    b.Property<string>("Remarks");

                    b.Property<int>("StatusCode");

                    b.HasKey("LoanId");

                    b.HasIndex("ApplicationUserId");

                    b.HasIndex("CustomerId");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("ProductId");

                    b.ToTable("Loans");
                });

            modelBuilder.Entity("Softmax.XCollections.Data.Entities.LoanApproval", b =>
                {
                    b.Property<string>("LoanApprovalId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CustomerId");

                    b.Property<DateTime>("DateCreated");

                    b.Property<string>("EmployeeId");

                    b.Property<string>("LoanId");

                    b.HasKey("LoanApprovalId");

                    b.HasIndex("CustomerId");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("LoanId");

                    b.ToTable("LoanApprovals");
                });

            modelBuilder.Entity("Softmax.XCollections.Data.Entities.Product", b =>
                {
                    b.Property<string>("ProductId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DateCreated");

                    b.Property<bool>("IsActive");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("Name");

                    b.Property<int>("ProductCode");

                    b.Property<int>("Rate");

                    b.Property<int>("Tenure");

                    b.HasKey("ProductId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("Softmax.XCollections.Data.Entities.Refund", b =>
                {
                    b.Property<string>("RefundId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Amount");

                    b.Property<int>("Balance");

                    b.Property<string>("CustomerId");

                    b.Property<DateTime>("DateCreated");

                    b.Property<string>("EmployeeId");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("LoanId");

                    b.Property<string>("Reference");

                    b.Property<int>("StatusCode");

                    b.HasKey("RefundId");

                    b.HasIndex("LoanId");

                    b.ToTable("Refunds");
                });

            modelBuilder.Entity("Softmax.XCollections.Data.Entities.RefundConfirm", b =>
                {
                    b.Property<string>("RefundConfirmId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CustomerId");

                    b.Property<DateTime>("DateCreated");

                    b.Property<string>("EmployeeId");

                    b.Property<string>("RefundId");

                    b.HasKey("RefundConfirmId");

                    b.HasIndex("CustomerId");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("RefundId");

                    b.ToTable("RefundConfirms");
                });

            modelBuilder.Entity("Softmax.XCollections.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("Address");

                    b.Property<string>("BranchId");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<DateTime>("DateCreated");

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<string>("FirstName");

                    b.Property<int>("GenderCode");

                    b.Property<bool>("IsActive");

                    b.Property<bool>("IsTempPassword");

                    b.Property<string>("LastName");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("MobileNumber");

                    b.Property<string>("NearestBusStop");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("Occupation");

                    b.Property<string>("OtherName");

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("Photo");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UniqueNumber");

                    b.Property<int>("UserCode");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("BranchId");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Softmax.XCollections.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Softmax.XCollections.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Softmax.XCollections.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Softmax.XCollections.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Softmax.XCollections.Data.Entities.Customer", b =>
                {
                    b.HasOne("Softmax.XCollections.Models.ApplicationUser", "AspNetUsers")
                        .WithMany()
                        .HasForeignKey("AspNetUsersId");
                });

            modelBuilder.Entity("Softmax.XCollections.Data.Entities.Deposit", b =>
                {
                    b.HasOne("Softmax.XCollections.Models.ApplicationUser")
                        .WithMany("Deposits")
                        .HasForeignKey("ApplicationUserId");

                    b.HasOne("Softmax.XCollections.Data.Entities.Customer", "Customer")
                        .WithMany("Deposits")
                        .HasForeignKey("CustomerId");

                    b.HasOne("Softmax.XCollections.Data.Entities.Employee", "Employee")
                        .WithMany("Deposits")
                        .HasForeignKey("EmployeeId");

                    b.HasOne("Softmax.XCollections.Data.Entities.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId");
                });

            modelBuilder.Entity("Softmax.XCollections.Data.Entities.DepositConfirm", b =>
                {
                    b.HasOne("Softmax.XCollections.Data.Entities.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId");

                    b.HasOne("Softmax.XCollections.Data.Entities.Deposit", "Deposit")
                        .WithMany()
                        .HasForeignKey("DepositId");

                    b.HasOne("Softmax.XCollections.Data.Entities.Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("EmployeeId");
                });

            modelBuilder.Entity("Softmax.XCollections.Data.Entities.Employee", b =>
                {
                    b.HasOne("Softmax.XCollections.Models.ApplicationUser", "AspNetUsers")
                        .WithMany()
                        .HasForeignKey("AspNetUsersId");
                });

            modelBuilder.Entity("Softmax.XCollections.Data.Entities.Loan", b =>
                {
                    b.HasOne("Softmax.XCollections.Models.ApplicationUser")
                        .WithMany("Loans")
                        .HasForeignKey("ApplicationUserId");

                    b.HasOne("Softmax.XCollections.Data.Entities.Customer", "Customer")
                        .WithMany("Loans")
                        .HasForeignKey("CustomerId");

                    b.HasOne("Softmax.XCollections.Data.Entities.Employee", "Employee")
                        .WithMany("Loans")
                        .HasForeignKey("EmployeeId");

                    b.HasOne("Softmax.XCollections.Data.Entities.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId");
                });

            modelBuilder.Entity("Softmax.XCollections.Data.Entities.LoanApproval", b =>
                {
                    b.HasOne("Softmax.XCollections.Data.Entities.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId");

                    b.HasOne("Softmax.XCollections.Data.Entities.Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("EmployeeId");

                    b.HasOne("Softmax.XCollections.Data.Entities.Loan", "Loan")
                        .WithMany()
                        .HasForeignKey("LoanId");
                });

            modelBuilder.Entity("Softmax.XCollections.Data.Entities.Refund", b =>
                {
                    b.HasOne("Softmax.XCollections.Data.Entities.Loan", "Loan")
                        .WithMany("Refunds")
                        .HasForeignKey("LoanId");
                });

            modelBuilder.Entity("Softmax.XCollections.Data.Entities.RefundConfirm", b =>
                {
                    b.HasOne("Softmax.XCollections.Data.Entities.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId");

                    b.HasOne("Softmax.XCollections.Data.Entities.Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("EmployeeId");

                    b.HasOne("Softmax.XCollections.Data.Entities.Refund", "Refund")
                        .WithMany()
                        .HasForeignKey("RefundId");
                });

            modelBuilder.Entity("Softmax.XCollections.Models.ApplicationUser", b =>
                {
                    b.HasOne("Softmax.XCollections.Data.Entities.Branch", "Branch")
                        .WithMany()
                        .HasForeignKey("BranchId");
                });
#pragma warning restore 612, 618
        }
    }
}
