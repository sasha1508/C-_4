﻿namespace Storage.Abstraction;

public interface IProductClient
{
    public Task<bool> Exists(int? id);
}