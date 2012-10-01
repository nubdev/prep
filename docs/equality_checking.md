#Rules for equality checking


##Is it a class (reference type)
  1. Does it implement IEquatable<T> for itself - use it
  2. Does it override Equals - use it
  3. Reference based equality check

##Is it a struct (value type)
  1. Does it implement IEquatable<T> for itself - use it
  2. Does it override Equals - use it
  3. Reflective field by field equality check
