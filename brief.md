QUIZ GAME CONSOLE APP

THE IDEA: A five-question quiz that keeps score, gives a grade at the end, and offers to play again until the user says no.

Requirements:

Start with two arrays declared at the top: a string[] holding five questions and a second string[] holding the five matching answers, in the same order. Something like:

string[] questions = { "What keyword declares a whole number?", ... };
string[] answers = { "int", ... };

Ask for the player's name with Console.ReadLine() and greet them using string interpolation. Tell them they can type skip to pass a question or quit to stop early.

Wrap the whole quiz in a do-while loop so it runs at least once and repeats for as long as the player wants another go. Set the score back to 0 at the start of each run.

Use a for loop to go through the questions, using the array's Length as the limit rather than typing 5. Print each question with its number, so the first one shows as "Question 1" even though its index is 0.

Read the player's answer and use an if / else if / else chain to decide what happens. If they typed skip, use continue to move straight to the next question. If they typed quit, use break to leave the loop. Otherwise compare their answer to the correct one with ==, print "Correct!" or "Wrong, the answer was ...", and add to the score with ++ when they get it right.

After the loop, print the score out of five and work out the percentage with * and /, storing it in an int.

Use a switch expression on the score to produce a grade: 5 is "A+", 4 is "A", 3 is "B", and the discard _ covers everything else as "C".

Use a ternary operator to print "Pass" when the score is 3 or more and "Fail" otherwise.

Finish by asking "Play again? (y/n)". The do-while condition checks whether the answer is "y". When it isn't, print a short goodbye message using the player's name and let the loop end naturally.

A few optional stretch goals once the core version works:

Keep a running total of questions answered across every round using a compound operator, and print it in the goodbye message; add a count of skipped questions and show it alongside the score.

Replace the Pass/Fail ternary with pattern matching (score is >= 4 and <= 5) to print "Great", "OK" or "Try again" bands; or move the grading into its own private method that takes the score and returns the grade as a string.

Add a second array of hints and print the matching hint when the player types hint, then ask the same question again using a while loop that keeps going until they give a real answer.