public static T RandomFrom<T>(IEnumerable<T> items)
{
    // If there are no items to choose from, return the default value for the type
    if (!items.Any())
        return default(T);

    // Use a random number generator
    Random rng = new Random();
    
    // Get a random index
    int index = rng.Next(items.Count());
    
    // Return the randomly selected item
    return items.ElementAt(index);
}

// Usage example:
// Assuming 'filteredFoldersWithFiles' is an IEnumerable<string> representing folder paths
var randomFolder = RandomFrom(filteredFoldersWithFiles);
return randomFolder;
