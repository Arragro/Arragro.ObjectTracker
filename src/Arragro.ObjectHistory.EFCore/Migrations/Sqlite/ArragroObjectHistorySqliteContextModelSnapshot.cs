﻿// <auto-generated />
using System;
using Arragro.ObjectHistory.EFCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Arragro.ObjectHistory.EFCore.Migrations.Sqlite
{
    [DbContext(typeof(ArragroObjectHistorySqliteContext))]
    partial class ArragroObjectHistorySqliteContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("object_history")
                .HasAnnotation("ProductVersion", "5.0.4");

            modelBuilder.Entity("Arragro.ObjectHistory.EFCore.ObjectHistoryDeletedTableEntity", b =>
                {
                    b.Property<string>("PartitionKey")
                        .HasColumnType("TEXT")
                        .HasColumnName("partition_key");

                    b.Property<long>("RowKey")
                        .HasColumnType("INTEGER")
                        .HasColumnName("row_key");

                    b.Property<string>("ApplicationName")
                        .HasColumnType("TEXT")
                        .HasColumnName("application_name");

                    b.Property<Guid>("Folder")
                        .HasColumnType("TEXT")
                        .HasColumnName("folder");

                    b.Property<string>("SecurityValidationToken")
                        .HasColumnType("TEXT")
                        .HasColumnName("security_validation_token");

                    b.Property<Guid?>("SubFolder")
                        .HasColumnType("TEXT")
                        .HasColumnName("sub_folder");

                    b.Property<long>("Timestamp")
                        .HasColumnType("INTEGER")
                        .HasColumnName("timestamp");

                    b.Property<string>("User")
                        .HasColumnType("TEXT")
                        .HasColumnName("user");

                    b.Property<int>("Version")
                        .HasColumnType("INTEGER")
                        .HasColumnName("version");

                    b.HasKey("PartitionKey", "RowKey")
                        .HasName("pk_object_history_deleted_table_entities");

                    b.HasIndex("RowKey")
                        .HasDatabaseName("ix_object_history_deleted_table_entities_row_key");

                    b.ToTable("object_history_deleted_table_entities");
                });

            modelBuilder.Entity("Arragro.ObjectHistory.EFCore.ObjectHistoryGlobalTableEntity", b =>
                {
                    b.Property<string>("PartitionKey")
                        .HasColumnType("TEXT")
                        .HasColumnName("partition_key");

                    b.Property<long>("RowKey")
                        .HasColumnType("INTEGER")
                        .HasColumnName("row_key");

                    b.Property<Guid>("Folder")
                        .HasColumnType("TEXT")
                        .HasColumnName("folder");

                    b.Property<bool>("IsAdd")
                        .HasColumnType("INTEGER")
                        .HasColumnName("is_add");

                    b.Property<string>("ObjectName")
                        .HasColumnType("TEXT")
                        .HasColumnName("object_name");

                    b.Property<string>("SecurityValidationToken")
                        .HasColumnType("TEXT")
                        .HasColumnName("security_validation_token");

                    b.Property<Guid?>("SubFolder")
                        .HasColumnType("TEXT")
                        .HasColumnName("sub_folder");

                    b.Property<long>("Timestamp")
                        .HasColumnType("INTEGER")
                        .HasColumnName("timestamp");

                    b.Property<string>("User")
                        .HasColumnType("TEXT")
                        .HasColumnName("user");

                    b.Property<int>("Version")
                        .HasColumnType("INTEGER")
                        .HasColumnName("version");

                    b.HasKey("PartitionKey", "RowKey")
                        .HasName("pk_object_history_global_table_entity");

                    b.HasIndex("RowKey")
                        .HasDatabaseName("ix_object_history_global_table_entity_row_key");

                    b.ToTable("object_history_global_table_entity");
                });

            modelBuilder.Entity("Arragro.ObjectHistory.EFCore.ObjectHistoryTableEntity", b =>
                {
                    b.Property<string>("PartitionKey")
                        .HasColumnType("TEXT")
                        .HasColumnName("partition_key");

                    b.Property<long>("RowKey")
                        .HasColumnType("INTEGER")
                        .HasColumnName("row_key");

                    b.Property<string>("ApplicationName")
                        .HasColumnType("TEXT")
                        .HasColumnName("application_name");

                    b.Property<Guid>("Folder")
                        .HasColumnType("TEXT")
                        .HasColumnName("folder");

                    b.Property<bool>("IsAdd")
                        .HasColumnType("INTEGER")
                        .HasColumnName("is_add");

                    b.Property<string>("SecurityValidationToken")
                        .HasColumnType("TEXT")
                        .HasColumnName("security_validation_token");

                    b.Property<Guid?>("SubFolder")
                        .HasColumnType("TEXT")
                        .HasColumnName("sub_folder");

                    b.Property<long>("Timestamp")
                        .HasColumnType("INTEGER")
                        .HasColumnName("timestamp");

                    b.Property<string>("User")
                        .HasColumnType("TEXT")
                        .HasColumnName("user");

                    b.Property<int>("Version")
                        .HasColumnType("INTEGER")
                        .HasColumnName("version");

                    b.HasKey("PartitionKey", "RowKey")
                        .HasName("pk_object_history_table_entity");

                    b.HasIndex("RowKey")
                        .HasDatabaseName("ix_object_history_table_entity_row_key");

                    b.ToTable("object_history_table_entity");
                });
#pragma warning restore 612, 618
        }
    }
}