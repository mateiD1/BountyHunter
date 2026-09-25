# Small code doc
## Objects
### Player
PlayerMovement class contains the movement of the Player object.
#### Movement
With an 'event', we check if player collides with any other object, and if yes, we allow it to execute jump again.
When mouse is turned (left to right), the whole player rotates.
### Camera
The only cam and for now main cam.
Is a child of the player.
When mouse moves forward, cam looks upward and vice versa.
