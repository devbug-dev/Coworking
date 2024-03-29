﻿using Coworking.DataContracts.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Coworking.DataAccess.EntityConfig
{
    public class ServiceEntityConfig
    {

        public static void SetEntityBuilder(EntityTypeBuilder<ServiceEntity> entityBuilder)
        {

            entityBuilder.ToTable("Services");

            entityBuilder.HasKey(x => x.Id);
            entityBuilder.Property(x => x.Id).IsRequired();


        }


    }
}
