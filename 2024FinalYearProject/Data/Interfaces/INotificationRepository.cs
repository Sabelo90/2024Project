﻿using _2024FinalYearProject.Models;

namespace _2024FinalYearProject.Data.Interfaces
{
    public interface INotificationRepository : IRepositoryBase<Notification>
    {
        Task<List<Notification>> GetUserMessages(string email);
    }
}
