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
    [Migration("20171102222931_CollectionModel")]
    partial class CollectionModel
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

                    b.Property<DateTime>("DateCreated");

                    b.Property<bool>("IsActive");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("Location");

                    b.Property<string>("State");

                    b.Property<int>("StateCode");

                    b.HasKey("BranchId");

                    b.ToTable("Branches");
                });

            modelBuilder.Entity("Softmax.XCollections.Data.Entities.Customer", b =>
                {
                    b.Property<string>("CustomerId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AccountNumber");

                    b.Property<DateTime>("DateCreated");

                    b.Property<string>("FirstName");

                    b.Property<string>("Gender");

                    b.Property<int>("GenderCode");

                    b.Property<bool>("IsActive");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("LastName");

                    b.Property<string>("Occupation");

                    b.Property<string>("OtherName");

                    b.Property<string>("Photo");

                    b.Property<string>("UserId");

                    b.HasKey("CustomerId");

                    b.HasIndex("UserId");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("Softmax.XCollections.Data.Entities.Deposit", b =>
                {
                    b.Property<string>("DepositId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Amount");

                    b.Property<int>("Balance");

                    b.Property<string>("CustomerId");

                    b.Property<DateTime>("DateCreated");

                    b.Property<string>("EmployeeId");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("ProductId");

                    b.Property<string>("Referrence");

                    b.Property<string>("Transaction");

                    b.Property<int>("TransactionCode");

                    b.HasKey("DepositId");

                    b.HasIndex("CustomerId");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("ProductId");

                    b.ToTable("Deposits");
                });

            modelBuilder.Entity("Softmax.XCollections.Data.Entities.Designation", b =>
                {
                    b.Property<string>("DesignationId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DateCreated");

                    b.Property<bool>("IsActive");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("Title");

                    b.HasKey("DesignationId");

                    b.ToTable("Designations");
                });

            modelBuilder.Entity("Softmax.XCollections.Data.Entities.Employee", b =>
                {
                    b.Property<string>("EmployeeId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("BranchId");

                    b.Property<DateTime>("DateCreated");

                    b.Property<string>("DesignationId");

                    b.Property<string>("EmployeeeNumber");

                    b.Property<DateTime?>("Employment");

                    b.Property<string>("FirstName");

                    b.Property<string>("Gender");

                    b.Property<int>("GenderCode");

                    b.Property<bool>("IsActive");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("LastName");

                    b.Property<DateTime?>("Termination");

                    b.Property<string>("UserId");

                    b.HasKey("EmployeeId");

                    b.HasIndex("BranchId");

                    b.HasIndex("DesignationId");

                    b.HasIndex("UserId");

                    b.ToTable("Employee");
                });

            modelBuilder.Entity("Softmax.XCollections.Data.Entities.LoanRefund", b =>
                {
                    b.Property<string>("LoanRefundId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Amount");

                    b.Property<int>("Balance");

                    b.Property<string>("CustomerId");

                    b.Property<DateTime>("DateCreated");

                    b.Property<string>("EmployeeId");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("LoanRequestId");

                    b.Property<string>("Reference");

                    b.HasKey("LoanRefundId");

                    b.HasIndex("CustomerId");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("LoanRequestId");

                    b.ToTable("LoanRefunds");
                });

            modelBuilder.Entity("Softmax.XCollections.Data.Entities.LoanRequest", b =>
                {
                    b.Property<string>("LoanRequestId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Amount");

                    b.Property<string>("CustomerId");

                    b.Property<DateTime?>("DateApproved");

                    b.Property<DateTime?>("DateCreated");

                    b.Property<DateTime?>("DueDate");

                    b.Property<string>("EmployeeId");

                    b.Property<int>("Interest");

                    b.Property<bool>("IsActive");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("ProductId");

                    b.Property<string>("Remarks");

                    b.Property<int>("StatusCode");

                    b.HasKey("LoanRequestId");

                    b.HasIndex("CustomerId");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("ProductId");

                    b.ToTable("LoanRequest");
                });

            modelBuilder.Entity("Softmax.XCollections.Data.Entities.Message", b =>
                {
                    b.Property<string>("MessageId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DateCreated");

                    b.Property<string>("EmployeeId");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("Note");

                    b.HasKey("MessageId");

                    b.HasIndex("EmployeeId");

                    b.ToTable("Messages");
                });

            modelBuilder.Entity("Softmax.XCollections.Data.Entities.Product", b =>
                {
                    b.Property<string>("ProductId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DatedCreated");

                    b.Property<bool>("IsActive");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("Name");

                    b.Property<int>("ProductCode");

                    b.Property<string>("ProductName");

                    b.Property<int>("Rate");

                    b.Property<int>("Tenure");

                    b.HasKey("ProductId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("Softmax.XCollections.Data.Entities.Withdrawal", b =>
                {
                    b.Property<string>("WithdrawalId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Amount");

                    b.Property<string>("CustomerId");

                    b.Property<string>("EmployeeId");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("Reference");

                    b.Property<string>("Remark");

                    b.Property<string>("Status");

                    b.Property<int>("StatusCode");

                    b.Property<DateTime>("WhenRequested");

                    b.Property<DateTime?>("WhenTreated");

                    b.HasKey("WithdrawalId");

                    b.HasIndex("CustomerId");

                    b.ToTable("Withdrawals");
                });

            modelBuilder.Entity("Softmax.XCollections.Data.tEntities.Guarantor", b =>
                {
                    b.Property<string>("GuarantorId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address");

                    b.Property<string>("CustomerId");

                    b.Property<DateTime>("DateCreated");

                    b.Property<string>("Email");

                    b.Property<bool>("IsAcceptable");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("LoanRequestId");

                    b.Property<string>("Name");

                    b.Property<string>("Phone");

                    b.Property<string>("State");

                    b.Property<int>("StateCode");

                    b.HasKey("GuarantorId");

                    b.HasIndex("CustomerId");

                    b.HasIndex("LoanRequestId");

                    b.ToTable("Guarantors");
                });

            modelBuilder.Entity("Softmax.XCollections.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

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
                    b.HasOne("Softmax.XCollections.Models.ApplicationUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("Softmax.XCollections.Data.Entities.Deposit", b =>
                {
                    b.HasOne("Softmax.XCollections.Data.Entities.Customer", "Customer")
                        .WithMany("Deposits")
                        .HasForeignKey("CustomerId");

                    b.HasOne("Softmax.XCollections.Data.Entities.Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("EmployeeId");

                    b.HasOne("Softmax.XCollections.Data.Entities.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId");
                });

            modelBuilder.Entity("Softmax.XCollections.Data.Entities.Employee", b =>
                {
                    b.HasOne("Softmax.XCollections.Data.Entities.Branch", "Branch")
                        .WithMany()
                        .HasForeignKey("BranchId");

                    b.HasOne("Softmax.XCollections.Data.Entities.Designation", "Designation")
                        .WithMany()
                        .HasForeignKey("DesignationId");

                    b.HasOne("Softmax.XCollections.Models.ApplicationUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("Softmax.XCollections.Data.Entities.LoanRefund", b =>
                {
                    b.HasOne("Softmax.XCollections.Data.Entities.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId");

                    b.HasOne("Softmax.XCollections.Data.Entities.Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("EmployeeId");

                    b.HasOne("Softmax.XCollections.Data.Entities.LoanRequest", "LoanRequest")
                        .WithMany("LoanRefunds")
                        .HasForeignKey("LoanRequestId");
                });

            modelBuilder.Entity("Softmax.XCollections.Data.Entities.LoanRequest", b =>
                {
                    b.HasOne("Softmax.XCollections.Data.Entities.Customer", "Customer")
                        .WithMany("LoanRequests")
                        .HasForeignKey("CustomerId");

                    b.HasOne("Softmax.XCollections.Data.Entities.Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("EmployeeId");

                    b.HasOne("Softmax.XCollections.Data.Entities.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId");
                });

            modelBuilder.Entity("Softmax.XCollections.Data.Entities.Message", b =>
                {
                    b.HasOne("Softmax.XCollections.Data.Entities.Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("EmployeeId");
                });

            modelBuilder.Entity("Softmax.XCollections.Data.Entities.Withdrawal", b =>
                {
                    b.HasOne("Softmax.XCollections.Data.Entities.Customer")
                        .WithMany("Withdrawals")
                        .HasForeignKey("CustomerId");
                });

            modelBuilder.Entity("Softmax.XCollections.Data.tEntities.Guarantor", b =>
                {
                    b.HasOne("Softmax.XCollections.Data.Entities.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId");

                    b.HasOne("Softmax.XCollections.Data.Entities.LoanRequest", "LoanRequest")
                        .WithMany("Guarantors")
                        .HasForeignKey("LoanRequestId");
                });
#pragma warning restore 612, 618
        }
    }
}
