﻿// <auto-generated />
using System;
using BoleteriaOnline.Web.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BoleteriaOnline.Web.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220130151837_TimeOnlyHoraHorario")]
    partial class TimeOnlyHoraHorario
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("BoleteriaOnline.Web.Data.Models.Boleto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<int>("Asiento")
                        .HasColumnType("int")
                        .HasColumnName("asiento");

                    b.Property<int?>("DestinoId")
                        .HasColumnType("int")
                        .HasColumnName("destino_id");

                    b.Property<string>("Estado")
                        .HasColumnType("longtext")
                        .HasColumnName("estado");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("fecha");

                    b.Property<DateTime>("FechaEmision")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("fecha_emision");

                    b.Property<string>("HoraLlegada")
                        .HasColumnType("longtext")
                        .HasColumnName("hora_llegada");

                    b.Property<string>("HoraSalida")
                        .HasColumnType("longtext")
                        .HasColumnName("hora_salida");

                    b.Property<string>("HoraSalidaAdicional")
                        .HasColumnType("longtext")
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
                        .HasColumnType("longtext")
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

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("created_at");

                    b.Property<int>("FilaId")
                        .HasColumnType("int")
                        .HasColumnName("fila_id");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime(6)")
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

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("created_at");

                    b.Property<int>("Estado")
                        .HasColumnType("int")
                        .HasColumnName("estado");

                    b.Property<DateTime>("FechaNac")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("fecha_nac");

                    b.Property<int?>("Genero")
                        .HasColumnType("int")
                        .HasColumnName("genero");

                    b.Property<string>("Nacionalidad")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("nacionalidad");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("nombre");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime(6)")
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

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("created_at");

                    b.Property<string>("Nombre")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("nombre");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("updated_at");

                    b.HasKey("Id")
                        .HasName("pk_destinos");

                    b.HasIndex("Nombre")
                        .IsUnique()
                        .HasDatabaseName("ix_destinos_nombre");

                    b.ToTable("destinos", (string)null);
                });

            modelBuilder.Entity("BoleteriaOnline.Web.Data.Models.Distribucion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("created_at");

                    b.Property<string>("Nota")
                        .HasMaxLength(128)
                        .HasColumnType("varchar(128)")
                        .HasColumnName("nota");

                    b.Property<bool>("UnPiso")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("un_piso");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("updated_at");

                    b.HasKey("Id")
                        .HasName("pk_distribuciones");

                    b.HasIndex("Nota")
                        .IsUnique()
                        .HasDatabaseName("ix_distribuciones_nota");

                    b.ToTable("distribuciones", (string)null);
                });

            modelBuilder.Entity("BoleteriaOnline.Web.Data.Models.Fila", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

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

                    b.Property<int>("DistribucionId")
                        .HasColumnType("int")
                        .HasColumnName("distribucion_id");

                    b.Property<bool>("Domingo")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("domingo");

                    b.Property<TimeOnly>("Hora")
                        .HasColumnType("time(6)")
                        .HasColumnName("hora");

                    b.Property<bool>("Jueves")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("jueves");

                    b.Property<bool>("Lunes")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("lunes");

                    b.Property<bool>("Martes")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("martes");

                    b.Property<bool>("Miercoles")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("miercoles");

                    b.Property<bool>("Sabado")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("sabado");

                    b.Property<int?>("ViajeId")
                        .HasColumnType("int")
                        .HasColumnName("viaje_id");

                    b.Property<bool>("Viernes")
                        .HasColumnType("tinyint(1)")
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

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("created_at");

                    b.Property<string>("Demora")
                        .HasMaxLength(5)
                        .HasColumnType("varchar(5)")
                        .HasColumnName("demora");

                    b.Property<int?>("DestinoId")
                        .HasColumnType("int")
                        .HasColumnName("destino_id");

                    b.Property<int?>("OrigenId")
                        .HasColumnType("int")
                        .HasColumnName("origen_id");

                    b.Property<float>("Precio")
                        .HasColumnType("float")
                        .HasColumnName("precio");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime(6)")
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

                    b.Property<int>("Boleto")
                        .HasColumnType("int")
                        .HasColumnName("boleto");

                    b.Property<string>("Codigo")
                        .HasColumnType("longtext")
                        .HasColumnName("codigo");

                    b.Property<string>("Correo")
                        .HasColumnType("longtext")
                        .HasColumnName("correo");

                    b.Property<long>("Dni")
                        .HasColumnType("bigint")
                        .HasColumnName("dni");

                    b.Property<DateTime>("Fecha_vencimiento")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("fecha_vencimiento");

                    b.Property<long>("Nro_tarjeta")
                        .HasColumnType("bigint")
                        .HasColumnName("nro_tarjeta");

                    b.Property<int>("Precio")
                        .HasColumnType("int")
                        .HasColumnName("precio");

                    b.Property<string>("Tarjeta")
                        .HasColumnType("longtext")
                        .HasColumnName("tarjeta");

                    b.Property<string>("Tipo")
                        .HasColumnType("longtext")
                        .HasColumnName("tipo");

                    b.Property<string>("Titular")
                        .HasColumnType("longtext")
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

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int")
                        .HasColumnName("access_failed_count");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("birth_date");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("longtext")
                        .HasColumnName("concurrency_stamp");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("created_at");

                    b.Property<string>("Email")
                        .HasColumnType("longtext")
                        .HasColumnName("email");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("email_confirmed");

                    b.Property<int>("Gender")
                        .HasColumnType("int")
                        .HasColumnName("gender");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("lockout_enabled");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("lockout_end");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("longtext")
                        .HasColumnName("normalized_email");

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("longtext")
                        .HasColumnName("normalized_user_name");

                    b.Property<string>("Password")
                        .HasMaxLength(150)
                        .HasColumnType("varchar(150)")
                        .HasColumnName("password");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("longtext")
                        .HasColumnName("password_hash");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("longtext")
                        .HasColumnName("phone_number");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("phone_number_confirmed");

                    b.Property<string>("Salt")
                        .HasColumnType("longtext")
                        .HasColumnName("salt");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("longtext")
                        .HasColumnName("security_stamp");

                    b.Property<int>("Tipo")
                        .HasColumnType("int")
                        .HasColumnName("tipo");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("two_factor_enabled");

                    b.Property<string>("UserName")
                        .HasColumnType("longtext")
                        .HasColumnName("user_name");

                    b.Property<string>("Username")
                        .HasMaxLength(25)
                        .HasColumnType("varchar(25)")
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

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("created_at");

                    b.Property<string>("Nombre")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("nombre");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("updated_at");

                    b.HasKey("Id")
                        .HasName("pk_viajes");

                    b.HasIndex("Nombre")
                        .IsUnique()
                        .HasDatabaseName("ix_viajes_nombre");

                    b.ToTable("viajes", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)")
                        .HasColumnName("id");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("longtext")
                        .HasColumnName("concurrency_stamp");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)")
                        .HasColumnName("name");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)")
                        .HasColumnName("normalized_name");

                    b.HasKey("Id")
                        .HasName("pk_asp_net_roles");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("ClaimType")
                        .HasColumnType("longtext")
                        .HasColumnName("claim_type");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("longtext")
                        .HasColumnName("claim_value");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("varchar(255)")
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
                        .HasColumnType("varchar(255)")
                        .HasColumnName("id");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int")
                        .HasColumnName("access_failed_count");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("longtext")
                        .HasColumnName("concurrency_stamp");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)")
                        .HasColumnName("email");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("email_confirmed");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("lockout_enabled");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("lockout_end");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)")
                        .HasColumnName("normalized_email");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)")
                        .HasColumnName("normalized_user_name");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("longtext")
                        .HasColumnName("password_hash");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("longtext")
                        .HasColumnName("phone_number");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("phone_number_confirmed");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("longtext")
                        .HasColumnName("security_stamp");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("two_factor_enabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)")
                        .HasColumnName("user_name");

                    b.HasKey("Id")
                        .HasName("pk_asp_net_users");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("ClaimType")
                        .HasColumnType("longtext")
                        .HasColumnName("claim_type");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("longtext")
                        .HasColumnName("claim_value");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(255)")
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
                        .HasColumnType("varchar(255)")
                        .HasColumnName("login_provider");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("varchar(255)")
                        .HasColumnName("provider_key");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("longtext")
                        .HasColumnName("provider_display_name");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(255)")
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
                        .HasColumnType("varchar(255)")
                        .HasColumnName("user_id");

                    b.Property<string>("RoleId")
                        .HasColumnType("varchar(255)")
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
                        .HasColumnType("varchar(255)")
                        .HasColumnName("user_id");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("varchar(255)")
                        .HasColumnName("login_provider");

                    b.Property<string>("Name")
                        .HasColumnType("varchar(255)")
                        .HasColumnName("name");

                    b.Property<string>("Value")
                        .HasColumnType("longtext")
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
