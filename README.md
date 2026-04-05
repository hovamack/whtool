# AI SPONGE Walkthrough

This guide explains how to set up and run the AI SPONGE project, which features AI-generated character dialogues with Text-to-Speech (TTS) and Discord integration.

## Prerequisites

- **Unity**: Version `2022.3.62f1`.
- **Python**: 3.7 or higher.
- **Python Libraries**:
  ```bash
  pip install discord.py cohere flask edge-tts
  ```
- **API Keys**:
  - **Discord Bot Token**: Create a bot on the [Discord Developer Portal](https://discord.com/developers/applications).
  - **Cohere API Key**: Get one from [Cohere](https://cohere.com/) (used in `main.py`).
  - **ElevenLabs API Key** (Optional): Used in `ElevenLabsTTS.cs` if you prefer high-quality voices.

## Setup Instructions

### 1. Configuration
- Open `Assets/Scripts/tokens.env` and add your keys:
  ```env
  DISCORD_TOKEN = your_discord_token_here
  OPENAI_API_KEY = your_key_here
  ```
- **Note**: `Assets/StreamingAssets/main.py` currently has a hardcoded `COHERE_API_KEY`. You may want to update it there as well.

### 2. Start the Python Services
- **TTS Server**: Required for "Free TTS" (Edge-TTS).
  ```bash
  python Assets/Scripts/tts_server.py
  ```
- **Discord Bot**: Generates the scripts via AI.
  ```bash
  python Assets/StreamingAssets/main.py
  ```

### 3. Unity Project
- Open the project in Unity Hub using version `2022.3.62f1`.
- Open the scene: `Assets/Scenes/Main.unity`.
- In the **Inspector** for the `DialogueManager` or `ElevenLabsTTS` objects, ensure the settings are correct (e.g., "Use Free Tts For All" if you don't have ElevenLabs).

## How to Run

1. **Press Play** in the Unity Editor.
2. **In Discord**, send a command to your bot in a channel it can see:
   - `!topic [Your topic here]` (e.g., `!topic SpongeBob talks about taxes`)
3. The bot will generate a script and append it to `all_topics.txt`.
4. Unity will detect the new topic and start playing the scene automatically.

### Commands
- `!topic [text]`: Queue a new scene.
- `!clear`: Clear the dialogue queue.
- `!fling [character]`: Trigger physics effect on a character.
- `!bwomp`: Play the "bwomp" sound effect.
- `!fog`: Enable fog.
- `!pixelate`: Enable pixelation effect.

## Troubleshooting
- **No Sound**: Ensure `tts_server.py` is running and accessible at `http://localhost:5000`.
- **Bot logic**: If the bot doesn't respond, check the console output of `main.py` for API errors.
