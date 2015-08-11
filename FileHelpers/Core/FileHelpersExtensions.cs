﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace FileHelpers
{
    /// <summary>
    /// Set of Extension methods to be exposed to end users 
    /// of the FileHelper API.
    /// </summary>
    public static class FileHelpersExtensions
    {
        /// <summary>
        /// Generic extension method for arrays that returns the array records
        /// in a DataTable.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="records">The array to transform into a DataTable</param>
        /// <returns>The array records in a DataTable.</returns>
        public static DataTable ToDataTable<T>(this T[] records)
        {
            var ri = RecordInfo.Resolve(typeof(T));

            return ri.Operations.RecordsToDataTable(records);
        }
    }
}
