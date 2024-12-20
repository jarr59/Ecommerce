﻿using Ecommerce.CommonClass;
using Ecommerce.Enums;
using MediatR;

namespace Ecommerce.Products.Commands;

/// <summary>
/// Comando para actualizar un producto
/// </summary>
/// <param name="ProductsToUpdate"></param>
public record UpdateProduct(List<UpdateProductInput> ProductsToUpdate, string AccountId) : IRequest<List<Product>>;


