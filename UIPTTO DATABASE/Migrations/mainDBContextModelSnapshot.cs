﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using UIPTTO_DATABASE.Models;

#nullable disable

namespace UIPTTO_DATABASE.Migrations
{
    [DbContext(typeof(mainDBContext))]
    partial class mainDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("UIPTTO_DATABASE.Models.CopyrightTable", b =>
                {
                    b.Property<int>("CId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("c_Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CId"), 1L, 1);

                    b.Property<DateTime?>("CApprDate")
                        .HasColumnType("date")
                        .HasColumnName("c_ApprDate");

                    b.Property<DateTime?>("CDateFiled")
                        .HasColumnType("date")
                        .HasColumnName("c_DateFiled");

                    b.Property<int?>("CRegNo")
                        .HasColumnType("int")
                        .HasColumnName("c_RegNo");

                    b.Property<string>("CStatus")
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)")
                        .HasColumnName("c_Status");

                    b.Property<string>("CTitle")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("c_Title");

                    b.Property<int?>("PId")
                        .HasColumnType("int")
                        .HasColumnName("p_Id");

                    b.HasKey("CId");

                    b.HasIndex("PId");

                    b.ToTable("copyright_Table");
                });

            modelBuilder.Entity("UIPTTO_DATABASE.Models.IsbnTable", b =>
                {
                    b.Property<int>("IsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("is_Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IsId"), 1L, 1);

                    b.Property<DateTime?>("IsApprDate")
                        .HasColumnType("date")
                        .HasColumnName("is_ApprDate");

                    b.Property<DateTime?>("IsDateFiled")
                        .HasColumnType("date")
                        .HasColumnName("is_DateFiled");

                    b.Property<int?>("IsIssuedNo")
                        .HasColumnType("int")
                        .HasColumnName("is_IssuedNo");

                    b.Property<string>("IsStatus")
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)")
                        .HasColumnName("is_Status");

                    b.Property<string>("IsTitle")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("is_Title");

                    b.Property<int?>("PId")
                        .HasColumnType("int")
                        .HasColumnName("p_Id");

                    b.HasKey("IsId");

                    b.HasIndex("PId");

                    b.ToTable("isbn_Table");
                });

            modelBuilder.Entity("UIPTTO_DATABASE.Models.IssnTable", b =>
                {
                    b.Property<int>("IId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("i_Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IId"), 1L, 1);

                    b.Property<DateTime?>("IApprDate")
                        .HasColumnType("date")
                        .HasColumnName("i_ApprDate");

                    b.Property<DateTime?>("IDateFiled")
                        .HasColumnType("date")
                        .HasColumnName("i_DateFiled");

                    b.Property<int?>("IIssuedNo")
                        .HasColumnType("int")
                        .HasColumnName("i_IssuedNo");

                    b.Property<string>("IStatus")
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)")
                        .HasColumnName("i_Status");

                    b.Property<string>("ITitle")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("i_Title");

                    b.Property<int?>("PId")
                        .HasColumnType("int")
                        .HasColumnName("p_Id");

                    b.HasKey("IId");

                    b.HasIndex("PId");

                    b.ToTable("issn_Table");
                });

            modelBuilder.Entity("UIPTTO_DATABASE.Models.PatentTable", b =>
                {
                    b.Property<int>("PtId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("pt_Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PtId"), 1L, 1);

                    b.Property<int?>("PId")
                        .HasColumnType("int")
                        .HasColumnName("p_Id");

                    b.Property<DateTime?>("PrApprDate")
                        .HasColumnType("date")
                        .HasColumnName("pr_ApprDate");

                    b.Property<DateTime?>("PtDateFiled")
                        .HasColumnType("date")
                        .HasColumnName("pt_DateFiled");

                    b.Property<int?>("PtRegNo")
                        .HasColumnType("int")
                        .HasColumnName("pt_RegNo");

                    b.Property<string>("PtStatus")
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)")
                        .HasColumnName("pt_Status");

                    b.Property<string>("PtTitle")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("pt_Title");

                    b.HasKey("PtId");

                    b.HasIndex("PId");

                    b.ToTable("patent_Table");
                });

            modelBuilder.Entity("UIPTTO_DATABASE.Models.ProfileTable", b =>
                {
                    b.Property<int>("PId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("p_Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PId"), 1L, 1);

                    b.Property<string>("PCollege")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("p_College");

                    b.Property<DateTime?>("PDob")
                        .HasColumnType("date")
                        .HasColumnName("p_DOB");

                    b.Property<string>("PEmail")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("p_Email");

                    b.Property<string>("PFname")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("p_Fname");

                    b.Property<string>("PGender")
                        .HasMaxLength(50)
                        .HasColumnType("nchar(50)")
                        .HasColumnName("p_Gender")
                        .IsFixedLength();

                    b.Property<string>("PLname")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("p_Lname");

                    b.HasKey("PId");

                    b.ToTable("profile_Table");
                });

            modelBuilder.Entity("UIPTTO_DATABASE.Models.TrademarkTable", b =>
                {
                    b.Property<int>("TId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("t_Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TId"), 1L, 1);

                    b.Property<DateTime?>("TApprDate")
                        .HasColumnType("date")
                        .HasColumnName("t_ApprDate");

                    b.Property<DateTime?>("TDateFiled")
                        .HasColumnType("date")
                        .HasColumnName("t_DateFiled");

                    b.Property<DateTime?>("TDaufiling")
                        .HasColumnType("date")
                        .HasColumnName("t_DAUFiling");

                    b.Property<DateTime?>("TExpiryDate")
                        .HasColumnType("date")
                        .HasColumnName("t_ExpiryDate");

                    b.Property<int?>("TRegNo")
                        .HasColumnType("int")
                        .HasColumnName("t_RegNo");

                    b.Property<string>("TStatus")
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)")
                        .HasColumnName("t_Status");

                    b.Property<string>("TTitle")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("t_Title");

                    b.HasKey("TId");

                    b.ToTable("trademark_Table");
                });

            modelBuilder.Entity("UIPTTO_DATABASE.Models.UserTable", b =>
                {
                    b.Property<int>("UId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("u_Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UId"), 1L, 1);

                    b.Property<string>("UCollege")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("u_College");

                    b.Property<DateTime?>("UDob")
                        .HasColumnType("date")
                        .HasColumnName("u_DOB");

                    b.Property<string>("UEmail")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("u_Email");

                    b.Property<string>("UFname")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("u_Fname");

                    b.Property<string>("UGender")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("char(10)")
                        .HasColumnName("u_Gender")
                        .IsFixedLength();

                    b.Property<string>("ULname")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("u_Lname");

                    b.Property<string>("UPassword")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("u_Password");

                    b.Property<string>("UType")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)")
                        .HasColumnName("u_type");

                    b.Property<string>("UUsername")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("u_Username");

                    b.HasKey("UId");

                    b.ToTable("user_Table");
                });

            modelBuilder.Entity("UIPTTO_DATABASE.Models.CopyrightTable", b =>
                {
                    b.HasOne("UIPTTO_DATABASE.Models.ProfileTable", "PIdNavigation")
                        .WithMany("CopyrightTables")
                        .HasForeignKey("PId")
                        .HasConstraintName("FK_copyright_Table_profile_Table");

                    b.Navigation("PIdNavigation");
                });

            modelBuilder.Entity("UIPTTO_DATABASE.Models.IsbnTable", b =>
                {
                    b.HasOne("UIPTTO_DATABASE.Models.ProfileTable", "PIdNavigation")
                        .WithMany("IsbnTables")
                        .HasForeignKey("PId")
                        .HasConstraintName("FK_isbn_Table_profile_Table");

                    b.Navigation("PIdNavigation");
                });

            modelBuilder.Entity("UIPTTO_DATABASE.Models.IssnTable", b =>
                {
                    b.HasOne("UIPTTO_DATABASE.Models.ProfileTable", "PIdNavigation")
                        .WithMany("IssnTables")
                        .HasForeignKey("PId")
                        .HasConstraintName("FK_issn_Table_profile_Table");

                    b.Navigation("PIdNavigation");
                });

            modelBuilder.Entity("UIPTTO_DATABASE.Models.PatentTable", b =>
                {
                    b.HasOne("UIPTTO_DATABASE.Models.ProfileTable", "PIdNavigation")
                        .WithMany("PatentTables")
                        .HasForeignKey("PId")
                        .HasConstraintName("FK_patent_Table_profile_Table");

                    b.Navigation("PIdNavigation");
                });

            modelBuilder.Entity("UIPTTO_DATABASE.Models.ProfileTable", b =>
                {
                    b.Navigation("CopyrightTables");

                    b.Navigation("IsbnTables");

                    b.Navigation("IssnTables");

                    b.Navigation("PatentTables");
                });
#pragma warning restore 612, 618
        }
    }
}
