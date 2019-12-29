﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated by a CodeSmith Template.
//
//     DO NOT MODIFY contents of this file. Changes to this
//     file will be lost if the code is regenerated.
// </autogenerated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OpenAuth.Repository.Mapping
{
    public partial class FlowInstanceOperationHistoryMap
        : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<OpenAuth.Repository.Domain.FlowInstanceOperationHistory>
    {
        public FlowInstanceOperationHistoryMap()
        {
            // table
            ToTable("FlowInstanceOperationHistory", "dbo");

            // keys
            HasKey(t => t.Id);

            // Properties
            Property(t => t.Id)
                .HasColumnName("Id")
                .HasMaxLength(50)
                .IsRequired();
            Property(t => t.InstanceId)
                .HasColumnName("InstanceId")
                .HasMaxLength(50)
                .IsRequired();
            Property(t => t.Content)
                .HasColumnName("Content")
                .HasMaxLength(200)
                .IsOptional();
            Property(t => t.CreateDate)
                .HasColumnName("CreateDate")
                .IsRequired();
            Property(t => t.CreateUserId)
                .HasColumnName("CreateUserId")
                .HasMaxLength(50)
                .IsOptional();
            Property(t => t.CreateUserName)
                .HasColumnName("CreateUserName")
                .HasMaxLength(50)
                .IsOptional();

            // Relationships
        }
    }
}
