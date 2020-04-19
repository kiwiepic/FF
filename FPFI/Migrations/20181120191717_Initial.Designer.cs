﻿// <auto-generated />
using System;
using FPFI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FPFI.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20181120191717_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FPFI.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("IsActivated");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<DateTime>("MemberSince");

                    b.Property<string>("Name");

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

            modelBuilder.Entity("FPFI.Models.Diam", b =>
                {
                    b.Property<long>("Id");

                    b.Property<int>("Entry2Id");

                    b.Property<int>("Idg");

                    b.Property<string>("Name");

                    b.Property<double>("Value");

                    b.HasKey("Id");

                    b.ToTable("Diams");
                });

            modelBuilder.Entity("FPFI.Models.Entry2", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AgeEnd");

                    b.Property<int>("AgeStart");

                    b.Property<string>("ApplicationUserId");

                    b.Property<string>("Description");

                    b.Property<double>("Deviation");

                    b.Property<int>("Distribution");

                    b.Property<int>("DistributionThinning");

                    b.Property<int>("HeightFunction");

                    b.Property<string>("IP");

                    b.Property<int>("Model");

                    b.Property<string>("Output");

                    b.Property<DateTime?>("ProcessStart");

                    b.Property<double?>("ProcessTime");

                    b.Property<int>("Species");

                    b.Property<int>("Stage");

                    b.Property<int>("VolumeFormula");

                    b.Property<int>("Way");

                    b.HasKey("Id");

                    b.HasIndex("ApplicationUserId");

                    b.ToTable("Entry2");
                });

            modelBuilder.Entity("FPFI.Models.Entry3", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AgeEnd");

                    b.Property<int>("AgeStart");

                    b.Property<string>("ApplicationUserId");

                    b.Property<bool>("ByClass");

                    b.Property<string>("Description");

                    b.Property<int>("Distribution");

                    b.Property<int>("DistributionThinning");

                    b.Property<string>("IP");

                    b.Property<bool>("Include_Thinning");

                    b.Property<double>("LengthDisc");

                    b.Property<double>("MgDisc");

                    b.Property<int>("Model");

                    b.Property<string>("Output");

                    b.Property<DateTime?>("ProcessStart");

                    b.Property<double?>("ProcessTime");

                    b.Property<int>("Stage");

                    b.Property<double>("Stump");

                    b.Property<int>("TreeId");

                    b.Property<int>("VolumeFormula");

                    b.Property<int>("Way");

                    b.HasKey("Id");

                    b.HasIndex("ApplicationUserId");

                    b.HasIndex("TreeId");

                    b.ToTable("Entry3");
                });

            modelBuilder.Entity("FPFI.Models.Input2", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Age");

                    b.Property<double>("BA");

                    b.Property<double>("D100");

                    b.Property<double>("Dg");

                    b.Property<int>("Entry2Id");

                    b.Property<double>("Hd");

                    b.Property<int>("Hm");

                    b.Property<int>("Hp");

                    b.Property<int>("Id_");

                    b.Property<string>("Macrostand");

                    b.Property<double>("N");

                    b.Property<string>("NAfterThins");

                    b.Property<int>("Pyear");

                    b.Property<string>("ThinCoefs");

                    b.Property<string>("ThinTypes");

                    b.Property<string>("ThinningAges");

                    b.Property<int>("Vt");

                    b.Property<int>("Years");

                    b.HasKey("Id");

                    b.HasIndex("Entry2Id");

                    b.ToTable("Input2");
                });

            modelBuilder.Entity("FPFI.Models.Input3", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Age");

                    b.Property<double>("BA");

                    b.Property<double>("D100");

                    b.Property<double>("DBH_max");

                    b.Property<double>("DBH_sd");

                    b.Property<double>("Dg");

                    b.Property<int>("Entry3Id");

                    b.Property<double>("Hd");

                    b.Property<int>("Hm");

                    b.Property<int>("Hp");

                    b.Property<int>("Id_");

                    b.Property<string>("Macrostand");

                    b.Property<double>("N");

                    b.Property<string>("NAfterThins");

                    b.Property<int>("Pyear");

                    b.Property<string>("Random_BA");

                    b.Property<string>("Random_SI");

                    b.Property<string>("ThinCoefs");

                    b.Property<string>("ThinTypes");

                    b.Property<string>("ThinningAges");

                    b.Property<int>("Vt");

                    b.Property<int>("Years");

                    b.HasKey("Id");

                    b.HasIndex("Entry3Id");

                    b.ToTable("Input3");
                });

            modelBuilder.Entity("FPFI.Models.Parameter2", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Alpha1");

                    b.Property<double>("Alpha2");

                    b.Property<double>("Beta1");

                    b.Property<double>("Beta2");

                    b.Property<double>("Beta3");

                    b.Property<double>("Beta4");

                    b.Property<int>("Entry2Id");

                    b.HasKey("Id");

                    b.HasIndex("Entry2Id")
                        .IsUnique();

                    b.ToTable("Parameter2");
                });

            modelBuilder.Entity("FPFI.Models.Parameter3", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Alpha1");

                    b.Property<double>("Alpha2");

                    b.Property<double>("Beta1");

                    b.Property<double>("Beta2");

                    b.Property<double>("Beta3");

                    b.Property<double>("Beta4");

                    b.Property<int>("Entry3Id");

                    b.HasKey("Id");

                    b.HasIndex("Entry3Id")
                        .IsUnique();

                    b.ToTable("Parameter3");
                });

            modelBuilder.Entity("FPFI.Models.Product2", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Diameter");

                    b.Property<int>("Entry2Id");

                    b.Property<int>("Length");

                    b.Property<int>("Priority");

                    b.Property<string>("X_1");

                    b.HasKey("Id");

                    b.HasIndex("Entry2Id");

                    b.ToTable("Product2");
                });

            modelBuilder.Entity("FPFI.Models.Product3", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Class");

                    b.Property<int>("Diameter");

                    b.Property<int>("Entry3Id");

                    b.Property<int>("Length");

                    b.Property<int>("LogType");

                    b.Property<int>("Value");

                    b.Property<string>("X_1");

                    b.HasKey("Id");

                    b.HasIndex("Entry3Id");

                    b.ToTable("Product3");
                });

            modelBuilder.Entity("FPFI.Models.Region", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Command");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Region");
                });

            modelBuilder.Entity("FPFI.Models.Simulation2", b =>
                {
                    b.Property<long>("Id");

                    b.Property<double>("Age");

                    b.Property<double>("BA");

                    b.Property<double?>("CAI_Dg");

                    b.Property<double?>("CAI_Vt");

                    b.Property<double>("Dg");

                    b.Property<string>("Distr");

                    b.Property<int>("Entry2Id");

                    b.Property<double>("Hd");

                    b.Property<int>("Id_");

                    b.Property<int>("Idg");

                    b.Property<double>("MAI_Dg");

                    b.Property<double>("MAI_Vt");

                    b.Property<string>("Macrostand");

                    b.Property<double>("N");

                    b.Property<double>("Sd");

                    b.Property<string>("ThinCoefs");

                    b.Property<string>("ThinTypes");

                    b.Property<double>("Thin_trees");

                    b.Property<bool>("Thinaction");

                    b.Property<double>("Vt");

                    b.HasKey("Id");

                    b.HasIndex("Entry2Id");

                    b.ToTable("Simulation2");
                });

            modelBuilder.Entity("FPFI.Models.Simulation3", b =>
                {
                    b.Property<long>("Id");

                    b.Property<double>("Age");

                    b.Property<double>("BA");

                    b.Property<double?>("CAI_Dg");

                    b.Property<double?>("CAI_Vt");

                    b.Property<double>("Dg");

                    b.Property<string>("Distr");

                    b.Property<int>("Entry3Id");

                    b.Property<double>("Hd");

                    b.Property<int>("Id_");

                    b.Property<int>("Idg");

                    b.Property<double>("MAI_Dg");

                    b.Property<double>("MAI_Vt");

                    b.Property<string>("Macrostand");

                    b.Property<double>("N");

                    b.Property<double>("Sd");

                    b.Property<string>("ThinCoefs");

                    b.Property<string>("ThinTypes");

                    b.Property<double>("Thin_trees");

                    b.Property<bool>("Thinaction");

                    b.Property<double>("Vt");

                    b.HasKey("Id");

                    b.HasIndex("Entry3Id");

                    b.ToTable("Simulation3");
                });

            modelBuilder.Entity("FPFI.Models.Species", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Command");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Species");
                });

            modelBuilder.Entity("FPFI.Models.Taper2", b =>
                {
                    b.Property<long>("Id");

                    b.Property<double>("Dbh");

                    b.Property<int>("Entry2Id");

                    b.Property<int>("Freq");

                    b.Property<int>("Hm");

                    b.Property<int>("Hp");

                    b.Property<double>("Ht");

                    b.Property<int>("Id_");

                    b.Property<int>("Idg");

                    b.Property<int>("Idgu");

                    b.Property<double>("MerchVol");

                    b.HasKey("Id");

                    b.HasIndex("Entry2Id");

                    b.ToTable("Taper2");
                });

            modelBuilder.Entity("FPFI.Models.TaperLog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Class");

                    b.Property<double>("Dbh");

                    b.Property<int>("Entry3Id");

                    b.Property<double>("Freq");

                    b.Property<string>("Grade");

                    b.Property<int>("Hm");

                    b.Property<int>("Hp");

                    b.Property<double>("Ht");

                    b.Property<int>("Id_");

                    b.Property<int>("Idg");

                    b.Property<int>("Idgu");

                    b.Property<int>("Idseq");

                    b.Property<double>("LED");

                    b.Property<double>("LED_h");

                    b.Property<int>("Log");

                    b.Property<string>("LogType");

                    b.Property<double>("MED");

                    b.Property<double>("MED_h");

                    b.Property<string>("Product");

                    b.Property<double>("SED");

                    b.Property<double>("SED_h");

                    b.Property<int>("Type");

                    b.Property<int>("Value");

                    b.Property<double>("Volume");

                    b.HasKey("Id");

                    b.HasIndex("Entry3Id");

                    b.ToTable("TaperLog");
                });

            modelBuilder.Entity("FPFI.Models.TaperStandHarvest", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Age");

                    b.Property<int>("Entry3Id");

                    b.Property<int>("Id_");

                    b.Property<int>("Idg");

                    b.Property<string>("Macrostand");

                    b.Property<double?>("NA");

                    b.Property<int>("Pyear");

                    b.HasKey("Id");

                    b.HasIndex("Entry3Id");

                    b.ToTable("TaperStandHarvest");
                });

            modelBuilder.Entity("FPFI.Models.TaperStandThinning", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Age");

                    b.Property<int>("Entry3Id");

                    b.Property<int>("Id_");

                    b.Property<int>("Idg");

                    b.Property<string>("Macrostand");

                    b.Property<double?>("NA");

                    b.Property<int>("Pyear");

                    b.Property<string>("Thin_name");

                    b.Property<int>("Thin_year");

                    b.HasKey("Id");

                    b.HasIndex("Entry3Id");

                    b.ToTable("TaperStandThinning");
                });

            modelBuilder.Entity("FPFI.Models.Tree", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Default");

                    b.Property<int>("RegionId");

                    b.Property<int>("SpeciesId");

                    b.HasKey("Id");

                    b.HasIndex("RegionId");

                    b.HasIndex("SpeciesId");

                    b.ToTable("Tree");
                });

            modelBuilder.Entity("FPFI.Models.VP", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Class");

                    b.Property<int>("Entry3Id");

                    b.Property<int>("Idg");

                    b.Property<int>("Type");

                    b.Property<double>("Value");

                    b.HasKey("Id");

                    b.HasIndex("Entry3Id");

                    b.ToTable("VP");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Discriminator")
                        .IsRequired();

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

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityRole");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

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
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ApplicationRoleId");

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("ApplicationRoleId");

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

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityUserRole<string>");
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

            modelBuilder.Entity("FPFI.Models.ApplicationRole", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityRole");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<string>("Description");

                    b.Property<string>("IPAddress");

                    b.ToTable("ApplicationRole");

                    b.HasDiscriminator().HasValue("ApplicationRole");
                });

            modelBuilder.Entity("FPFI.Models.ApplicationUserRole", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityUserRole<string>");

                    b.Property<string>("RoleAssigner");

                    b.ToTable("ApplicationUserRole");

                    b.HasDiscriminator().HasValue("ApplicationUserRole");
                });

            modelBuilder.Entity("FPFI.Models.Entry2", b =>
                {
                    b.HasOne("FPFI.Models.ApplicationUser", "ApplicationUser")
                        .WithMany("Entry2")
                        .HasForeignKey("ApplicationUserId");
                });

            modelBuilder.Entity("FPFI.Models.Entry3", b =>
                {
                    b.HasOne("FPFI.Models.ApplicationUser", "ApplicationUser")
                        .WithMany("Entry3")
                        .HasForeignKey("ApplicationUserId");

                    b.HasOne("FPFI.Models.Tree", "Tree")
                        .WithMany("Entries")
                        .HasForeignKey("TreeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("FPFI.Models.Input2", b =>
                {
                    b.HasOne("FPFI.Models.Entry2", "Entry")
                        .WithMany("Inputs")
                        .HasForeignKey("Entry2Id")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("FPFI.Models.Input3", b =>
                {
                    b.HasOne("FPFI.Models.Entry3", "Entry")
                        .WithMany("Inputs")
                        .HasForeignKey("Entry3Id")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("FPFI.Models.Parameter2", b =>
                {
                    b.HasOne("FPFI.Models.Entry2", "Entry2")
                        .WithOne("Parameter")
                        .HasForeignKey("FPFI.Models.Parameter2", "Entry2Id")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("FPFI.Models.Parameter3", b =>
                {
                    b.HasOne("FPFI.Models.Entry3", "Entry3")
                        .WithOne("Parameter")
                        .HasForeignKey("FPFI.Models.Parameter3", "Entry3Id")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("FPFI.Models.Product2", b =>
                {
                    b.HasOne("FPFI.Models.Entry2", "Entry")
                        .WithMany("Products")
                        .HasForeignKey("Entry2Id")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("FPFI.Models.Product3", b =>
                {
                    b.HasOne("FPFI.Models.Entry3", "Entry")
                        .WithMany("Products")
                        .HasForeignKey("Entry3Id")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("FPFI.Models.Simulation2", b =>
                {
                    b.HasOne("FPFI.Models.Entry2", "Entry2")
                        .WithMany("Simulations")
                        .HasForeignKey("Entry2Id")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("FPFI.Models.Simulation3", b =>
                {
                    b.HasOne("FPFI.Models.Entry3", "Entry3")
                        .WithMany("Simulations")
                        .HasForeignKey("Entry3Id")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("FPFI.Models.Taper2", b =>
                {
                    b.HasOne("FPFI.Models.Entry2", "Entry")
                        .WithMany("Tapers")
                        .HasForeignKey("Entry2Id")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("FPFI.Models.TaperLog", b =>
                {
                    b.HasOne("FPFI.Models.Entry3", "Entry3")
                        .WithMany("TaperLogs")
                        .HasForeignKey("Entry3Id")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("FPFI.Models.TaperStandHarvest", b =>
                {
                    b.HasOne("FPFI.Models.Entry3", "Entry3")
                        .WithMany("TaperStandHarvests")
                        .HasForeignKey("Entry3Id")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("FPFI.Models.TaperStandThinning", b =>
                {
                    b.HasOne("FPFI.Models.Entry3", "Entry3")
                        .WithMany("TaperStandThinnings")
                        .HasForeignKey("Entry3Id")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("FPFI.Models.Tree", b =>
                {
                    b.HasOne("FPFI.Models.Region", "Region")
                        .WithMany("Trees")
                        .HasForeignKey("RegionId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("FPFI.Models.Species", "Species")
                        .WithMany("Trees")
                        .HasForeignKey("SpeciesId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("FPFI.Models.VP", b =>
                {
                    b.HasOne("FPFI.Models.Entry3", "Entry")
                        .WithMany("VPs")
                        .HasForeignKey("Entry3Id")
                        .OnDelete(DeleteBehavior.Cascade);
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
                    b.HasOne("FPFI.Models.ApplicationRole")
                        .WithMany("Claims")
                        .HasForeignKey("ApplicationRoleId");

                    b.HasOne("FPFI.Models.ApplicationUser")
                        .WithMany("Claims")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("FPFI.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("FPFI.Models.ApplicationRole")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .HasConstraintName("FK_AspNetUserRoles_AspNetRoles_RoleId1")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("FPFI.Models.ApplicationUser")
                        .WithMany("Roles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("FPFI.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}