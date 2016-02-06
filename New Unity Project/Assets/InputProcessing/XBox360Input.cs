﻿using XInputDotNetPure;

public class XBox360Input {
    public delegate float SticksDel(float f = 1);
    public SticksDel leftStickY, leftStickX, rightStickX, rightStickY, rightTrigger, leftTrigger;
    public delegate ButtonState ButtonDelegate(bool b = true);
    public ButtonDelegate buttonA, buttonB, buttonX, buttonY,
        buttonLB, buttonRB, buttonLT, buttonRT,
        buttonStart, buttonBack;

    PlayerIndex playerIndex;

    public XBox360Input(int playerNumber)
    {
        playerIndex = (PlayerIndex)playerNumber;
        InitializeXboxController();
    }

    void InitializeXboxController()
    {
        leftStickY = x => GamePad.GetState(playerIndex).ThumbSticks.Left.Y;
        leftStickX = x => GamePad.GetState(playerIndex).ThumbSticks.Left.X;
        rightStickY = x => GamePad.GetState(playerIndex).ThumbSticks.Right.Y;
        rightStickX = x => GamePad.GetState(playerIndex).ThumbSticks.Right.X;

        leftTrigger = x => GamePad.GetState(playerIndex).Triggers.Left;
        rightTrigger = x => GamePad.GetState(playerIndex).Triggers.Right;

        buttonA = x => GamePad.GetState(playerIndex).Buttons.A;
        buttonB = x => GamePad.GetState(playerIndex).Buttons.B;
        buttonX = x => GamePad.GetState(playerIndex).Buttons.X;
        buttonY = x => GamePad.GetState(playerIndex).Buttons.Y;

        buttonLB = x => GamePad.GetState(playerIndex).Buttons.LeftShoulder;
        buttonRB = x => GamePad.GetState(playerIndex).Buttons.RightShoulder;
        buttonLT = x => GamePad.GetState(playerIndex).Buttons.LeftShoulder;
        buttonRT = x => GamePad.GetState(playerIndex).Buttons.RightShoulder;

        buttonStart = x => GamePad.GetState(playerIndex).Buttons.Start;
        buttonBack = x => GamePad.GetState(playerIndex).Buttons.Back;
    }
}
