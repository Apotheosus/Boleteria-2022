﻿using System.Collections.Generic;
using System.Linq;

namespace BoleteriaOnline.Web.Extensions;
public static class ForEachExtensions
{
    public static IEnumerable<(T item, int index)> WithIndex<T>(this IEnumerable<T> self) => self.Select((item, index) => (item, index));
}
