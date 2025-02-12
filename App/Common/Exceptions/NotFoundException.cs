﻿namespace CCG.Notification.Application.Common.Exceptions;

public class NotFoundException : Exception
{
    public NotFoundException()
        : base()
    {
    }

    public NotFoundException(string message)
        : base(message)
    {
    }

    public NotFoundException(string message, Exception innerException)
        : base(message, innerException)
    {
    }
    
    public NotFoundException(string name, object Id, object Pk)
        : base($"Entity \"{name}\" (Id: {Id}, Pk: {Pk}) was not found.")
    {
    }
}