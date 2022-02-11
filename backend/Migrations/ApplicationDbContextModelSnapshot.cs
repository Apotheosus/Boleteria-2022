﻿// <auto-generated />
using System;
using BoleteriaOnline.Web.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BoleteriaOnline.Web.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("BoleteriaOnline.Web.Data.Models.Boleto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Asiento")
                        .HasColumnType("int")
                        .HasColumnName("asiento");

                    b.Property<int?>("DestinoId")
                        .HasColumnType("int")
                        .HasColumnName("destino_id");

                    b.Property<string>("Estado")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("estado");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2")
                        .HasColumnName("fecha");

                    b.Property<DateTime>("FechaEmision")
                        .HasColumnType("datetime2")
                        .HasColumnName("fecha_emision");

                    b.Property<string>("HoraLlegada")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("hora_llegada");

                    b.Property<string>("HoraSalida")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("hora_salida");

                    b.Property<string>("HoraSalidaAdicional")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("hora_salida_adicional");

                    b.Property<int?>("OrigenId")
                        .HasColumnType("int")
                        .HasColumnName("origen_id");

                    b.Property<int?>("PagoId")
                        .HasColumnType("int")
                        .HasColumnName("pago_id");

                    b.Property<long?>("PasajeroId")
                        .HasColumnType("bigint")
                        .HasColumnName("pasajero_id");

                    b.Property<string>("Precio")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("precio");

                    b.Property<int?>("RecorridoId")
                        .HasColumnType("int")
                        .HasColumnName("recorrido_id");

                    b.Property<long?>("VendedorId")
                        .HasColumnType("bigint")
                        .HasColumnName("vendedor_id");

                    b.HasKey("Id")
                        .HasName("pk_boletos");

                    b.HasIndex("DestinoId")
                        .HasDatabaseName("ix_boletos_destino_id");

                    b.HasIndex("OrigenId")
                        .HasDatabaseName("ix_boletos_origen_id");

                    b.HasIndex("PagoId")
                        .HasDatabaseName("ix_boletos_pago_id");

                    b.HasIndex("PasajeroId")
                        .HasDatabaseName("ix_boletos_pasajero_id");

                    b.HasIndex("RecorridoId")
                        .HasDatabaseName("ix_boletos_recorrido_id");

                    b.HasIndex("VendedorId")
                        .HasDatabaseName("ix_boletos_vendedor_id");

                    b.ToTable("boletos", (string)null);
                });

            modelBuilder.Entity("BoleteriaOnline.Web.Data.Models.Celda", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("created_at");

                    b.Property<int>("FilaId")
                        .HasColumnType("int")
                        .HasColumnName("fila_id");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("updated_at");

                    b.Property<int>("Value")
                        .HasColumnType("int")
                        .HasColumnName("value");

                    b.HasKey("Id")
                        .HasName("pk_celdas");

                    b.HasIndex("FilaId")
                        .HasDatabaseName("ix_celdas_fila_id");

                    b.ToTable("celdas", (string)null);
                });

            modelBuilder.Entity("BoleteriaOnline.Web.Data.Models.Cliente", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("created_at");

                    b.Property<int>("Estado")
                        .HasColumnType("int")
                        .HasColumnName("estado");

                    b.Property<DateTime>("FechaNac")
                        .HasColumnType("datetime2")
                        .HasColumnName("fecha_nac");

                    b.Property<int?>("Genero")
                        .HasColumnType("int")
                        .HasColumnName("genero");

                    b.Property<string>("Nacionalidad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("nacionalidad");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("nombre");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("updated_at");

                    b.HasKey("Id")
                        .HasName("pk_clientes");

                    b.ToTable("clientes", (string)null);
                });

            modelBuilder.Entity("BoleteriaOnline.Web.Data.Models.Destino", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("created_at");

                    b.Property<string>("Nombre")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("nombre");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("updated_at");

                    b.HasKey("Id")
                        .HasName("pk_destinos");

                    b.HasIndex("Nombre")
                        .IsUnique()
                        .HasDatabaseName("ix_destinos_nombre")
                        .HasFilter("[nombre] IS NOT NULL");

                    b.ToTable("destinos", (string)null);
                });

            modelBuilder.Entity("BoleteriaOnline.Web.Data.Models.Distribucion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("created_at");

                    b.Property<string>("Nota")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)")
                        .HasColumnName("nota");

                    b.Property<bool>("UnPiso")
                        .HasColumnType("bit")
                        .HasColumnName("un_piso");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("updated_at");

                    b.HasKey("Id")
                        .HasName("pk_distribuciones");

                    b.HasIndex("Nota")
                        .IsUnique()
                        .HasDatabaseName("ix_distribuciones_nota")
                        .HasFilter("[nota] IS NOT NULL");

                    b.ToTable("distribuciones", (string)null);
                });

            modelBuilder.Entity("BoleteriaOnline.Web.Data.Models.Fila", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("DistribucionId")
                        .HasColumnType("int")
                        .HasColumnName("distribucion_id");

                    b.Property<int>("Planta")
                        .HasColumnType("int")
                        .HasColumnName("planta");

                    b.HasKey("Id")
                        .HasName("pk_filas");

                    b.HasIndex("DistribucionId")
                        .HasDatabaseName("ix_filas_distribucion_id");

                    b.ToTable("filas", (string)null);
                });

            modelBuilder.Entity("BoleteriaOnline.Web.Data.Models.Horario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("DistribucionId")
                        .HasColumnType("int")
                        .HasColumnName("distribucion_id");

                    b.Property<bool>("Domingo")
                        .HasColumnType("bit")
                        .HasColumnName("domingo");

                    b.Property<DateTime>("Hora")
                        .HasColumnType("datetime2")
                        .HasColumnName("hora");

                    b.Property<bool>("Jueves")
                        .HasColumnType("bit")
                        .HasColumnName("jueves");

                    b.Property<bool>("Lunes")
                        .HasColumnType("bit")
                        .HasColumnName("lunes");

                    b.Property<bool>("Martes")
                        .HasColumnType("bit")
                        .HasColumnName("martes");

                    b.Property<bool>("Miercoles")
                        .HasColumnType("bit")
                        .HasColumnName("miercoles");

                    b.Property<bool>("Sabado")
                        .HasColumnType("bit")
                        .HasColumnName("sabado");

                    b.Property<int?>("ViajeId")
                        .HasColumnType("int")
                        .HasColumnName("viaje_id");

                    b.Property<bool>("Viernes")
                        .HasColumnType("bit")
                        .HasColumnName("viernes");

                    b.HasKey("Id")
                        .HasName("pk_horarios");

                    b.HasIndex("ViajeId")
                        .HasDatabaseName("ix_horarios_viaje_id");

                    b.ToTable("horarios", (string)null);
                });

            modelBuilder.Entity("BoleteriaOnline.Web.Data.Models.Nodo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("created_at");

                    b.Property<string>("Demora")
                        .HasMaxLength(5)
                        .HasColumnType("nvarchar(5)")
                        .HasColumnName("demora");

                    b.Property<int?>("DestinoId")
                        .HasColumnType("int")
                        .HasColumnName("destino_id");

                    b.Property<int?>("OrigenId")
                        .HasColumnType("int")
                        .HasColumnName("origen_id");

                    b.Property<float>("Precio")
                        .HasColumnType("real")
                        .HasColumnName("precio");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("updated_at");

                    b.Property<int?>("ViajeId")
                        .HasColumnType("int")
                        .HasColumnName("viaje_id");

                    b.HasKey("Id")
                        .HasName("pk_nodos");

                    b.HasIndex("DestinoId")
                        .HasDatabaseName("ix_nodos_destino_id");

                    b.HasIndex("OrigenId")
                        .HasDatabaseName("ix_nodos_origen_id");

                    b.HasIndex("ViajeId")
                        .HasDatabaseName("ix_nodos_viaje_id");

                    b.ToTable("nodos", (string)null);
                });

            modelBuilder.Entity("BoleteriaOnline.Web.Data.Models.Pago", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Boleto")
                        .HasColumnType("int")
                        .HasColumnName("boleto");

                    b.Property<string>("Codigo")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("codigo");

                    b.Property<string>("Correo")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("correo");

                    b.Property<long>("Dni")
                        .HasColumnType("bigint")
                        .HasColumnName("dni");

                    b.Property<DateTime>("Fecha_vencimiento")
                        .HasColumnType("datetime2")
                        .HasColumnName("fecha_vencimiento");

                    b.Property<long>("Nro_tarjeta")
                        .HasColumnType("bigint")
                        .HasColumnName("nro_tarjeta");

                    b.Property<int>("Precio")
                        .HasColumnType("int")
                        .HasColumnName("precio");

                    b.Property<string>("Tarjeta")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("tarjeta");

                    b.Property<string>("Tipo")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("tipo");

                    b.Property<string>("Titular")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("titular");

                    b.HasKey("Id")
                        .HasName("pk_pagos");

                    b.ToTable("pagos", (string)null);
                });

            modelBuilder.Entity("BoleteriaOnline.Web.Data.Models.Usuario", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int")
                        .HasColumnName("access_failed_count");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("birth_date");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("concurrency_stamp");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("created_at");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("email");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit")
                        .HasColumnName("email_confirmed");

                    b.Property<int>("Gender")
                        .HasColumnType("int")
                        .HasColumnName("gender");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit")
                        .HasColumnName("lockout_enabled");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset")
                        .HasColumnName("lockout_end");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("normalized_email");

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("normalized_user_name");

                    b.Property<string>("Password")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)")
                        .HasColumnName("password");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("password_hash");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("phone_number");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit")
                        .HasColumnName("phone_number_confirmed");

                    b.Property<string>("Salt")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("salt");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("security_stamp");

                    b.Property<int>("Tipo")
                        .HasColumnType("int")
                        .HasColumnName("tipo");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit")
                        .HasColumnName("two_factor_enabled");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("user_name");

                    b.Property<string>("Username")
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)")
                        .HasColumnName("username");

                    b.HasKey("Id")
                        .HasName("pk_usuarios");

                    b.ToTable("usuarios", (string)null);
                });

            modelBuilder.Entity("BoleteriaOnline.Web.Data.Models.Viaje", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("created_at");

                    b.Property<string>("Nombre")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("nombre");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("updated_at");

                    b.HasKey("Id")
                        .HasName("pk_viajes");

                    b.HasIndex("Nombre")
                        .IsUnique()
                        .HasDatabaseName("ix_viajes_nombre")
                        .HasFilter("[nombre] IS NOT NULL");

                    b.ToTable("viajes", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("id");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("concurrency_stamp");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)")
                        .HasColumnName("name");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)")
                        .HasColumnName("normalized_name");

                    b.HasKey("Id")
                        .HasName("pk_asp_net_roles");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[normalized_name] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("claim_type");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("claim_value");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("role_id");

                    b.HasKey("Id")
                        .HasName("pk_asp_net_role_claims");

                    b.HasIndex("RoleId")
                        .HasDatabaseName("ix_asp_net_role_claims_role_id");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("id");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int")
                        .HasColumnName("access_failed_count");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("concurrency_stamp");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)")
                        .HasColumnName("email");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit")
                        .HasColumnName("email_confirmed");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit")
                        .HasColumnName("lockout_enabled");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset")
                        .HasColumnName("lockout_end");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)")
                        .HasColumnName("normalized_email");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)")
                        .HasColumnName("normalized_user_name");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("password_hash");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("phone_number");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit")
                        .HasColumnName("phone_number_confirmed");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("security_stamp");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit")
                        .HasColumnName("two_factor_enabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)")
                        .HasColumnName("user_name");

                    b.HasKey("Id")
                        .HasName("pk_asp_net_users");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[normalized_user_name] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("claim_type");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("claim_value");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("user_id");

                    b.HasKey("Id")
                        .HasName("pk_asp_net_user_claims");

                    b.HasIndex("UserId")
                        .HasDatabaseName("ix_asp_net_user_claims_user_id");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("login_provider");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("provider_key");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("provider_display_name");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("user_id");

                    b.HasKey("LoginProvider", "ProviderKey")
                        .HasName("pk_asp_net_user_logins");

                    b.HasIndex("UserId")
                        .HasDatabaseName("ix_asp_net_user_logins_user_id");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("user_id");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("role_id");

                    b.HasKey("UserId", "RoleId")
                        .HasName("pk_asp_net_user_roles");

                    b.HasIndex("RoleId")
                        .HasDatabaseName("ix_asp_net_user_roles_role_id");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("user_id");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("login_provider");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("name");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("value");

                    b.HasKey("UserId", "LoginProvider", "Name")
                        .HasName("pk_asp_net_user_tokens");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("BoleteriaOnline.Web.Data.Models.Boleto", b =>
                {
                    b.HasOne("BoleteriaOnline.Web.Data.Models.Destino", "Destino")
                        .WithMany()
                        .HasForeignKey("DestinoId")
                        .HasConstraintName("fk_boletos_destinos_destino_id");

                    b.HasOne("BoleteriaOnline.Web.Data.Models.Destino", "Origen")
                        .WithMany()
                        .HasForeignKey("OrigenId")
                        .HasConstraintName("fk_boletos_destinos_origen_id");

                    b.HasOne("BoleteriaOnline.Web.Data.Models.Pago", "Pago")
                        .WithMany()
                        .HasForeignKey("PagoId")
                        .HasConstraintName("fk_boletos_pagos_pago_id");

                    b.HasOne("BoleteriaOnline.Web.Data.Models.Cliente", "Pasajero")
                        .WithMany()
                        .HasForeignKey("PasajeroId")
                        .HasConstraintName("fk_boletos_clientes_pasajero_id");

                    b.HasOne("BoleteriaOnline.Web.Data.Models.Viaje", "Recorrido")
                        .WithMany()
                        .HasForeignKey("RecorridoId")
                        .HasConstraintName("fk_boletos_viajes_recorrido_id");

                    b.HasOne("BoleteriaOnline.Web.Data.Models.Usuario", "Vendedor")
                        .WithMany()
                        .HasForeignKey("VendedorId")
                        .HasConstraintName("fk_boletos_usuarios_vendedor_id");

                    b.Navigation("Destino");

                    b.Navigation("Origen");

                    b.Navigation("Pago");

                    b.Navigation("Pasajero");

                    b.Navigation("Recorrido");

                    b.Navigation("Vendedor");
                });

            modelBuilder.Entity("BoleteriaOnline.Web.Data.Models.Celda", b =>
                {
                    b.HasOne("BoleteriaOnline.Web.Data.Models.Fila", null)
                        .WithMany("Cells")
                        .HasForeignKey("FilaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_celdas_filas_fila_id");
                });

            modelBuilder.Entity("BoleteriaOnline.Web.Data.Models.Fila", b =>
                {
                    b.HasOne("BoleteriaOnline.Web.Data.Models.Distribucion", null)
                        .WithMany("Filas")
                        .HasForeignKey("DistribucionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_filas_distribuciones_distribucion_id");
                });

            modelBuilder.Entity("BoleteriaOnline.Web.Data.Models.Horario", b =>
                {
                    b.HasOne("BoleteriaOnline.Web.Data.Models.Viaje", null)
                        .WithMany("Horarios")
                        .HasForeignKey("ViajeId")
                        .HasConstraintName("fk_horarios_viajes_viaje_id");
                });

            modelBuilder.Entity("BoleteriaOnline.Web.Data.Models.Nodo", b =>
                {
                    b.HasOne("BoleteriaOnline.Web.Data.Models.Destino", "Destino")
                        .WithMany()
                        .HasForeignKey("DestinoId")
                        .HasConstraintName("fk_nodos_destinos_destino_id");

                    b.HasOne("BoleteriaOnline.Web.Data.Models.Destino", "Origen")
                        .WithMany()
                        .HasForeignKey("OrigenId")
                        .HasConstraintName("fk_nodos_destinos_origen_id");

                    b.HasOne("BoleteriaOnline.Web.Data.Models.Viaje", null)
                        .WithMany("Nodos")
                        .HasForeignKey("ViajeId")
                        .HasConstraintName("fk_nodos_viajes_viaje_id");

                    b.Navigation("Destino");

                    b.Navigation("Origen");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_asp_net_role_claims_asp_net_roles_role_id");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_asp_net_user_claims_asp_net_users_user_id");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_asp_net_user_logins_asp_net_users_user_id");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_asp_net_user_roles_asp_net_roles_role_id");

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_asp_net_user_roles_asp_net_users_user_id");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_asp_net_user_tokens_asp_net_users_user_id");
                });

            modelBuilder.Entity("BoleteriaOnline.Web.Data.Models.Distribucion", b =>
                {
                    b.Navigation("Filas");
                });

            modelBuilder.Entity("BoleteriaOnline.Web.Data.Models.Fila", b =>
                {
                    b.Navigation("Cells");
                });

            modelBuilder.Entity("BoleteriaOnline.Web.Data.Models.Viaje", b =>
                {
                    b.Navigation("Horarios");

                    b.Navigation("Nodos");
                });
#pragma warning restore 612, 618
        }
    }
}
