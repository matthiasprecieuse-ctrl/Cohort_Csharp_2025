using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Filtering & Projection:
//Where() – filters a sequence of values based on a predicate.
//Select() – projects each element of a sequence into a new form.
//SelectMany() – projects each element into an IEnumerable<T> and flattens the sequences.
//OfType() – filters elements based on type.
//Cast() – casts the elements to a specified type.
//Sorting & Grouping:
//OrderBy() – sorts in ascending order.
//OrderByDescending() – sorts in descending order.
//GroupBy() – groups elements by a key.
//Join() – correlates elements of two sequences by matching keys.
//GroupJoin() – correlates and groups elements of two sequences.
//Set Operations:
//Distinct() – removes duplicates.
//Union() – set union (removes duplicates).
//Intersect() – set intersection.
//Except() – set difference.
//Concat() – concatenates sequences.
//SequenceEqual() – compares sequences for equality.
//Element Operations:
//First() – first element.
//FirstOrDefault() – first element or default.
//Single() – only element (error if not exactly one).
//SingleOrDefault() – only element or default (error if more than one).
//ElementAt() – element at index.
//ElementAtOrDefault() – element at index or default.
//DefaultIfEmpty() – sequence or default if empty.
//Quantifiers:
//Any() – checks if any element satisfies a condition.
//All() – checks if all elements satisfy a condition.
//Contains() – checks if sequence contains an element.
//Aggregation:
//Count() – counts elements.
//Sum() – sum of numeric values.
//Average() – average of numeric values.
//Max() – maximum value.
//Min() – minimum value.
//Aggregate() – accumulator function over a sequence.
//Partitioning:
//Take() – takes first N elements.
//Skip() – skips first N elements.
//Conversion:
//ToList() – creates a List<T>.
//ToArray() – creates an array.
//ToDictionary() – creates a Dictionary<TKey,TValue>.
//ToLookup() – creates a Lookup<TKey,TElement>.
//AsEnumerable() – returns input as IEnumerable<T>.
//AsQueryable() – returns input as IQueryable<T>.
//Generation:
//Range() – generates a range of integers.
//Repeat() – repeats a value.
//Empty() – empty sequence.
//Miscellaneous
//Zip() – merges two sequences into pairs.
//Reverse() – reverses order of elements.
//ForEach() – performs an action for each element (not in LINQ standard, but in List<T>).
