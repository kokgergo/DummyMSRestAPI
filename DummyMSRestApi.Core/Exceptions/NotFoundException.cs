﻿namespace DummyMSRestApi.Core.Exceptions
{
    public class NotFoundException : ApplicationException
    {
        public NotFoundException(string name, object key) : base($"{name} with ({key}) was not found") 
        { }
    }
}
