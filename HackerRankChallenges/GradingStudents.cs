public static List<int> gradingStudents(List<int> grades)
{
    for (int i = 0; i < grades.Count; i++)
    {
        int grade = grades[i]; // Get the current grade from the list
        
        if (grade >= 38) // Check if the grade is 38 or higher
        {
            int diff = 5 - (grade % 5); // Calculate the difference needed to round up to the nearest multiple of 5
            
            if (diff < 3) // Check if the difference is less than 3
                grades[i] = grade + diff; // Round up the grade by adding the difference
        }
    }

    return grades; // Return the updated grades list
}

