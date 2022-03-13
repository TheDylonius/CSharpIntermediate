using System;
using System.Collections.Generic;

namespace CSharpIntermediate.Models
{
    class Stack
    {
        private List<object> Items = new List<object>();

        public void Push(object obj)
        {
            if (obj == null)
            {
                throw new InvalidOperationException();
            }

            try
            {
                Items.Add(obj);
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }
        }

        public object Pop()
        {
            if (Items.Count == 0)
            {
                throw new InvalidOperationException();
            }

            // Get the last item from the list.
            var lastItem = Items[Items.Count - 1];

            // Remove the last item from the list.
            Items.RemoveAt(Items.Count - 1);

            // Return the previously last item from the list.
            return lastItem;
        }

        public void Clear()
        {
            foreach (var item in Items)
            {
                Items.Remove(item);
            }
        }
    }
}