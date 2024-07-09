﻿using Calculator.Main.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Interface.Services
{
    public interface ICalculatorHistoryService
    {
        Task Add(CalculatorHistory history);
        Task<List<CalculatorHistory>> GetHistories(int page, int limit);
    }
}
