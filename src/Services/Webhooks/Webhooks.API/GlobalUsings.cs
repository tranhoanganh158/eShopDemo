﻿global using System;
global using System.Collections.Generic;
global using System.ComponentModel.DataAnnotations;
global using System.Data.Common;
global using System.Linq;
global using System.Net;
global using System.Net.Http;
global using System.Text;
global using System.Text.Json;
global using System.Threading.Tasks;
global using Microsoft.AspNetCore.Authorization;
global using Microsoft.AspNetCore.Builder;
global using Microsoft.AspNetCore.Hosting;
global using Microsoft.AspNetCore.Http;
global using Microsoft.AspNetCore.Mvc;
global using Microsoft.EntityFrameworkCore;
global using Microsoft.EntityFrameworkCore.Design;
global using Microsoft.eShopOnContainers.BuildingBlocks.EventBus.Abstractions;
global using Microsoft.eShopOnContainers.BuildingBlocks.EventBus.Events;
global using Microsoft.eShopOnContainers.BuildingBlocks.IntegrationEventLogEF.Services;
global using Microsoft.Extensions.Configuration;
global using Microsoft.Extensions.DependencyInjection;
global using Microsoft.Extensions.Logging;
global using Services.Common;
global using Webhooks.API.Infrastructure;
global using Webhooks.API.IntegrationEvents;
global using Webhooks.API.Model;
global using Webhooks.API.Services;