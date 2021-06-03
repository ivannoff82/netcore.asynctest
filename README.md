# netcore.asynctest

Example net.core console project.
It shows very simple example how async/await works.

One async method runs as object async method. It increase indexer value field.
Second async method runs from Application static class and shows indexer value at console.

At any time you can press "enter" and program closing cause end ReadLine waiting. 
Program shows 3 "independent" async threads - increase/console log/wait user data enter
