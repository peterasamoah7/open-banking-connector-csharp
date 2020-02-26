﻿// Licensed to Finnovation Labs Limited under one or more agreements.
// Finnovation Labs Limited licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Web;
using Newtonsoft.Json;

namespace FinnovationLabs.OpenBanking.Library.Connector
{
    internal static class Extensions
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TResult Maybe<T, TResult>(this T value, Func<T, TResult> selector)
            where T : class
        {
            return value != null
                ? selector(value)
                : default;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static IEnumerable<T> NullToEmpty<T>(this IEnumerable<T> values)
        {
            return values ?? Enumerable.Empty<T>();
        }

        public static IEnumerable<T> WalkRecursive<T>(this T value, Func<T, T> selector)
            where T : class
        {
            return WalkRecursiveInner(value, selector.ArgNotNull(nameof(selector)));
        }


        public static Task<T> ToTaskResult<T>(this T value)
        {
            return Task.FromResult(value);
        }

        public static async Task<T[]> WaitAll<T>(this Task<T>[] tasks)
        {
            return await Task.WhenAll(tasks);
        }

        public static int DelimiterCount(this string value, char delimiter)
        {
            var count = 0;
            var x = 0;
            do
            {
                x = value.IndexOf(delimiter, x);
                if (x < 0)
                {
                    return count;
                }

                count++;
                x++;
            } while (x < value.Length);

            return count;
        }

        // HACK: the repetitive reflection over types will incur performance costs in future - please optimise
        public static Dictionary<string, object> ToObjectDictionary<T>(this T value)
            where T : class
        {
            value.ArgNotNull(nameof(value));

            var props = typeof(T).GetProperties(BindingFlags.Instance | BindingFlags.Public |
                                                BindingFlags.FlattenHierarchy);

            var pairs = props.Select(p => new
            {
                Prop = p.GetGetMethod(),
                Attr = p.GetCustomAttribute<JsonPropertyAttribute>()
            }).Where(a => a.Attr != null && a.Prop != null);

            var result = new Dictionary<string, object>(StringComparer.InvariantCulture);
            foreach (var pair in pairs)
            {
                var propValue = pair.Prop.Invoke(value, null);

                result[pair.Attr.PropertyName] = propValue;
            }

            return result;
        }

        public static bool IsInNamespace(this Type type, Type rootType)
        {
            type.ArgNotNull(nameof(type));
            rootType.ArgNotNull(nameof(rootType));

            return rootType.Namespace != null &&
                   type.Namespace.Maybe(n => n.StartsWith(rootType.Namespace));
        }

        public static string JoinString(this IEnumerable<string> lines, string delimiter)
        {
            return string.Join(delimiter, lines.ArgNotNull(nameof(lines)));
        }


        public static string ToUrlEncoded(this IEnumerable<KeyValuePair<string, string>> values)
        {
            var result = values.Select(kvp =>
                    $"{HttpUtility.UrlPathEncode(kvp.Key)}={HttpUtility.UrlPathEncode(kvp.Value)}")
                .JoinString("&");

            return result;
        }

        private static IEnumerable<T> WalkRecursiveInner<T>(T value, Func<T, T> selector) where T : class
        {
            while (value != null)
            {
                yield return value;

                value = selector(value);
            }
        }
    }
}