﻿// <auto-generated />
using System;
using Arragro.ObjectHistory.EFCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Arragro.ObjectHistory.EFCore.Migrations.Postgres
{
    [DbContext(typeof(ArragroObjectHistoryPGContext))]
    partial class ArragroObjectHistoryPGContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("object_history")
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.4")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("Arragro.ObjectHistory.EFCore.ObjectHistoryDeletedTableEntity", b =>
                {
                    b.Property<string>("PartitionKey")
                        .HasColumnType("text");

                    b.Property<long>("RowKey")
                        .HasColumnType("bigint");

                    b.Property<string>("ApplicationName")
                        .HasColumnType("text");

                    b.Property<Guid>("Folder")
                        .HasColumnType("uuid");

                    b.Property<string>("Metadata")
                        .HasColumnType("text");

                    b.Property<string>("SecurityValidationToken")
                        .HasColumnType("text");

                    b.Property<Guid?>("SubFolder")
                        .HasColumnType("uuid");

                    b.Property<DateTimeOffset>("Timestamp")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("User")
                        .HasColumnType("text");

                    b.Property<int>("Version")
                        .HasColumnType("integer");

                    b.HasKey("PartitionKey", "RowKey");

                    b.HasIndex("RowKey");

                    b.ToTable("ObjectHistoryDeletedTableEntities");
                });

            modelBuilder.Entity("Arragro.ObjectHistory.EFCore.ObjectHistoryGlobalTableEntity", b =>
                {
                    b.Property<string>("PartitionKey")
                        .HasMaxLength(1024)
                        .HasColumnType("character varying(1024)");

                    b.Property<long>("RowKey")
                        .HasMaxLength(50)
                        .HasColumnType("bigint");

                    b.Property<Guid>("Folder")
                        .HasColumnType("uuid");

                    b.Property<bool>("IsAdd")
                        .HasColumnType("boolean");

                    b.Property<string>("Metadata")
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<string>("ObjectName")
                        .HasColumnType("text");

                    b.Property<string>("SecurityValidationToken")
                        .HasColumnType("text");

                    b.Property<Guid?>("SubFolder")
                        .HasColumnType("uuid");

                    b.Property<DateTimeOffset>("Timestamp")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("User")
                        .HasColumnType("text");

                    b.Property<int>("Version")
                        .HasColumnType("integer");

                    b.HasKey("PartitionKey", "RowKey");

                    b.HasIndex("RowKey");

                    b.ToTable("ObjectHistoryGlobalTableEntity");
                });

            modelBuilder.Entity("Arragro.ObjectHistory.EFCore.ObjectHistoryTableEntity", b =>
                {
                    b.Property<string>("PartitionKey")
                        .HasColumnType("text");

                    b.Property<long>("RowKey")
                        .HasColumnType("bigint");

                    b.Property<string>("ApplicationName")
                        .HasColumnType("text");

                    b.Property<Guid>("Folder")
                        .HasColumnType("uuid");

                    b.Property<bool>("IsAdd")
                        .HasColumnType("boolean");

                    b.Property<string>("Metadata")
                        .HasColumnType("text");

                    b.Property<string>("SecurityValidationToken")
                        .HasColumnType("text");

                    b.Property<Guid?>("SubFolder")
                        .HasColumnType("uuid");

                    b.Property<DateTimeOffset>("Timestamp")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("User")
                        .HasColumnType("text");

                    b.Property<int>("Version")
                        .HasColumnType("integer");

                    b.HasKey("PartitionKey", "RowKey");

                    b.HasIndex("RowKey");

                    b.ToTable("ObjectHistoryTableEntity");
                });
#pragma warning restore 612, 618
        }
    }
}
