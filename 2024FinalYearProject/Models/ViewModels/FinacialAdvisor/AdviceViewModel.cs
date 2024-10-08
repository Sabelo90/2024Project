﻿namespace _2024FinalYearProject.Models.ViewModels.FinacialAdvisor
{
    public class AdviceViewModel
    {
      public  AppUser AppUser { get; set; }
      public  AppUser Client { get; set; }
       public BankAccount BankAccount { get; set; }
      public  List<Transaction> Transactions { get; set; }
      public decimal MoneyIn { get; set; }
      public decimal MoneyOut { get; set;}
        public int adviceId { get; set; }
    }
    public class PendingAdviseModel
    {
        public AppUser User { get; set; }
        public List<Advice> PendingAdvices { get; set; }
        
    }
}
