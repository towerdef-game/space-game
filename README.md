# Space game

# Storyboard
 
![](/images/storyboard.jpg)

## slide 1
crew gets into the tachi spaceship
## slide 2
enemies attack the fleeing ship, tachi fires back
## slide 3
tachi destroys hanger doors
## slide 4
Donnager bridge about to be overrun 
## slide 5
tachi escapes the Donnager
## slide 6
Donnager self-destructs

## inspired by this scene from the series The Expanse
https://www.youtube.com/watch?v=bf3I-XkOkHM&ab_channel=Deterrence
## Where the assets came from 
the ship model for the tachi and donnager came from sketchfab, while the drones and catwalks were from the unity store.
The sound were taken from the website freesounds.
everything else (effects models etc) was made by me using the unity assets i.e unity particles/trail.
## What I used to make level
I used triggers that would activate the next scene once a certain point was reached. the cinematic should work just download and click play.
##What Behaviours I used 
I used a flocking behaviour I found on youtube to create the swarm of drones that was circle the hanger scene link:https://www.youtube.com/watch?v=mBVarJm3Tgk .
I used a nev mesh agent to get the pilot to move 
I used a waypoint script that makes the ship move and rotate to different points when it reachs certain waypoints
I made a courinte that would count down and when it was up it would play an animtion of the turrets on the ship opening then it would activate a script that would rotate the guns and fire at two targets that were invisible but would move around the map to simulate the ship firing at the drones. 
