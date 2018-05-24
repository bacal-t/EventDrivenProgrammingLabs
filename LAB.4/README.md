
# Report

## Laboratory work Nr. 4

### Title : Windows Timer. Animation.

### Laboratory Work requirements

#### Bonus Objectives:

- Increase and decrease animation speed using mouse wheel (2 pt)
- Solve flickering problem (2 pt) please describe in your readme/report how you did it
- Add animated objects which interact with each other (2-6 pt), ex.:
 - Few balls which have different velocity and moving angles. In order to get max points, add balls with mouse, make balls to change color on interaction and any other things that will show your engineering spirit
 - Any other interesting and reach in animation application
- Animate a Nyan Cat that leaves a rainbow tail (Math.floor(+35% for task with interacting objects))

 
## Laboratory Work Implementation

### Result
Implemented in C#

- On click - balls of random colors and with different velocities appear.
- When balls interacts with the window boundaries they change their movement direction and color(2-6p)
- Balls velocity can be changed with mouse wheel (2pt)
When you press space the nyan cat appears and she is moving to the right
- When nyan cat and balls collide, the balls change colors.
- Flickering problem was solved by using double - buffer.(2pt)



### Conclusion
In this laboratory work I got know how to work with some animation using timer and a little bit of our creativity.. At the beginning of the work, I met the flickering problem, in this case I used double buffering, because when you use two buffers while an image /frame is shown a separate frame is buffered to be shown next. Working with C# instead of C++ saved me a lot of time.
