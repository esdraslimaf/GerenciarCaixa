﻿// <auto-generated />
using System;
using GerenciarCaixa.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GerenciarCaixa.Persistence.Migrations
{
    [DbContext(typeof(MyContext))]
    [Migration("20240926062845_inicial")]
    partial class inicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.33")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("GerenciarCaixa.Domain.Entities.Mesa", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTimeOffset?>("DateCreated")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTimeOffset?>("DateTimeDeleted")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTimeOffset?>("DateUpdated")
                        .HasColumnType("datetimeoffset");

                    b.Property<bool?>("Disponivel")
                        .HasColumnType("bit");

                    b.Property<string>("IdentificaMesa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Mesas");
                });
#pragma warning restore 612, 618
        }
    }
}
