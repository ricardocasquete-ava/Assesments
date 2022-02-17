import RoverSimulator from "../components/rover-simulator"

test("Output should be '0 0 E' based on (Direction='', Position={X=0,Y=0}, Command=MMMMMRMMMMM)", () => {
    const roverSimulator = new RoverSimulator({
        commands: "MMMMMRMMMMM",
        hasUI: false
    });
    roverSimulator.executeAllCommands();
    expect(roverSimulator.getCoordinates()).toBe("0 0 E");
});

test("Output should be back to '0 0 N' based on (Direction='', Position={X=0,Y=0}, Command=MMMMMRMMMMM) after resetting the board", () => {
    const roverSimulator = new RoverSimulator({
        commands: "MMMMMRMMMMM",
        hasUI: false
    });
    roverSimulator.executeAllCommands();
    roverSimulator.resetGame();
    expect(roverSimulator.getCoordinates()).toBe("0 0 N");
});

test("Output should be '1 3 N' based on (Direction=N, Position={X=1,Y=2}, Command=LMLMLMLMM)", () => {
    const roverSimulator = new RoverSimulator({
        dimensions: [10, 10],
        roverPosition: [1, 2],
        direction: "N",
        commands: "LMLMLMLMM",
        hasUI: false
    });
    roverSimulator.executeAllCommands();
    expect(roverSimulator.getCoordinates()).toBe("1 3 N");
});

test("Output should be back to '1 2 N' based on (Direction=N, Position={X=1,Y=2}, Command=LMLMLMLMM) after resetting the board", () => {
    const roverSimulator = new RoverSimulator({
        dimensions: [10, 10],
        roverPosition: [1, 2],
        direction: "N",
        commands: "LMLMLMLMM",
        hasUI: false
    });
    roverSimulator.executeAllCommands();
    roverSimulator.resetGame();
    expect(roverSimulator.getCoordinates()).toBe("1 2 N");
});

test("Output should be '5 1 E' based on (Direction=E, Position={X=3,Y=3}, Command=MMRMMRMRRM)", () => {
    const roverSimulator = new RoverSimulator({
        dimensions: [10, 10],
        roverPosition: [3, 3],
        direction: "E",
        commands: "MMRMMRMRRM",
        hasUI: false
    });
    roverSimulator.executeAllCommands();
    expect(roverSimulator.getCoordinates()).toBe("5 1 E");
});

test("Output should be back to '3 3 E' based on (Direction=E, Position={X=3,Y=3}, Command=MMRMMRMRRM) after resetting the board", () => {
    const roverSimulator = new RoverSimulator({
        dimensions: [10, 10],
        roverPosition: [3, 3],
        direction: "E",
        commands: "MMRMMRMRRM",
        hasUI: false
    });
    roverSimulator.executeAllCommands();
    roverSimulator.resetGame();
    expect(roverSimulator.getCoordinates()).toBe("3 3 E");
});