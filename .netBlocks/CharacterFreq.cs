Dictionary<string, int> d = new Dictionary<string, string>();
 foreach (var item in Invalid_IDs)
 {
      if (d.Keys.Contains(item))
      {
          d[item] += 1;
      }
      else
      {
          d.Add(item, 1);
      }
  }
  StringBuilder b = new StringBuilder();
  foreach (var item in d)
  {
      b.Append("<br>" + item.Key + ": " + item.Value);
  }

  var duplicateString = b.ToString();
