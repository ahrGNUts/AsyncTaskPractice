# AsyncTaskPractice
Trying to get more practice with multithreading/async tasks outside of a strictly
web context, so here we are. Looking to directly apply these concepts to another
C# project of mine that's been on back burner for a little while.

## Description
User will be able to start/stop 4 different background workers that will independently
update the text on their own specific textareas. Background workers can be paused at will
and restarted as needed.

## TODO
- implement remaining button event handlers
- generalize event handlers (since their code is very similar with the exception of the updated textareas)