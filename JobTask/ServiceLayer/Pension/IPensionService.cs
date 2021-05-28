﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobTask.ServiceLayer.Pension
{
    public interface IPensionService
    {
        /// <summary>
        /// some methods
        /// </summary>
        /// <returns></returns>
        Task<PensionModel> GetPensionDataAsync();
        Task<ErrorResultModel> PostDataAsync(PensionModel model);
    }
}