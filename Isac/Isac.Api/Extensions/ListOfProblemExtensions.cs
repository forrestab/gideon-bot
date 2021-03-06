﻿using Isac.Api.Models;
using System.Collections.Generic;
using System.Linq;

namespace Isac.Api.Extensions
{
    public static class ListOfProblemExtensions
    {
        public static List<Problem> Merge(this List<Problem> list1, List<Problem> list2)
        {
            return list1
                .Concat(list2)
                .GroupBy(g => g.Key, (key, values) => new Problem()
                {
                    Key = key,
                    Message = $"[{key}]({values.First().ResourceUrl.CombinePath(key)}) {string.Join(" and ", values.Select(s => s.Message))}"
                })
                .Select(s => s)
                .ToList<Problem>();
        }
    }
}
