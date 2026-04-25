# Obstacle Course Game

## Overview
This is a 3D obstacle course game developed using Unity. The player controls a cube that must navigate through various obstacles without hitting them. The game tracks the number of times the player bumps into obstacles.

## Screenshots
![Gameplay GIF](assets/gameplay.gif)

![Obstacle Course View](assets/obstacle_course.png)

![Player Movement](assets/player_movement.png)

## Game Structure
The project is organized into the following main directories:

- **Assets/**: Contains all game assets
  - **Materials/**: Material files for visual appearance (Dodgy, Obstacle, Plane, StartFinish)
  - **Prefabs/**: Reusable game objects (Dodgy, Dropper, Obstacle, Roller, Spinner)
  - **Scenes/**: Game scenes (SampleScene)
  - **Scripts/**: C# scripts for game logic
- **Packages/**: Unity package dependencies
- **ProjectSettings/**: Unity project configuration files

## Implemented Features

### Core Mechanics
- **Player Movement**: Smooth movement using keyboard input
- **Collision Detection**: Objects change color when hit by the player
- **Scoring System**: Tracks the number of obstacle collisions
- **Dynamic Obstacles**: Various types of moving and appearing obstacles

### Scripts
- **Mover.cs**: Handles player movement and displays game instructions
- **ObjectHit.cs**: Manages collision responses, changing object colors and tags
- **Scorer.cs**: Counts and displays collision hits
- **Spinner.cs**: Rotates obstacles continuously
- **Dropper.cs**: Delays obstacle appearance, then enables gravity for falling objects

### Obstacle Types
- **Spinners**: Rotating obstacles that spin on configurable axes
- **Droppers**: Objects that appear after a delay and fall due to gravity
- **Static Obstacles**: Fixed barriers that change color when hit
- **Dodgy**: Special obstacle type (specific behavior defined in prefab)

## How the Game Works
1. The game starts with the player cube positioned in the obstacle course
2. The player must navigate through the course using movement controls
3. Various obstacles are present:
   - Some spin continuously to create moving challenges
   - Some appear after delays and fall from above
   - Others are static barriers
4. When the player collides with an obstacle:
   - The obstacle turns red
   - A "hit" is counted and displayed in the console
   - The obstacle is tagged as "Hit" to prevent multiple counts
5. The goal is to complete the course with as few hits as possible

## Player Controls
- **Movement**: Use WASD keys or arrow keys to move the cube
- **Objective**: Navigate through the obstacle course while avoiding collisions

## Running the Game
1. Open the project in Unity
2. Load the `SampleScene` from the Scenes folder
3. Press Play to start the game
4. Use the controls to move through the obstacle course

## Development Notes
- Built with Unity 3D
- Uses Unity's physics system for collisions and gravity
- Implements component-based architecture with MonoBehaviour scripts
- Utilizes Unity's input system for player controls