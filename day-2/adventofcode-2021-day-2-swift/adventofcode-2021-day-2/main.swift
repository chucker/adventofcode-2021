//
//  main.swift
//  adventofcode-2021-day-2
//
//  Created by Sören Kuklau on 02.12.21.
//

import Foundation

calculatePosition(filename: "test-input.txt")

calculatePosition(filename: "input.txt")

func calculatePosition(filename : String) {
    var position = SubmarinePosition(Horizontal: 0, Depth: 0, Aim: 0)
    
    let content = try? String(contentsOfFile: filename)
    
    let regex = try! NSRegularExpression(pattern: #"(?<Command>\w+) (?<Argument>\d+)"#)
    
    for line in content!.components(separatedBy: .newlines) {
        if line == "" {
            break
        }
        
        let range = NSRange(location: 0, length: line.utf16.count)
        
        let match = regex.firstMatch(in: line, options: [], range: range)!
        
        let command = line[Range(match.range(withName: "Command"), in: line)!]
        let argument = Int(line[Range(match.range(withName: "Argument"), in: line)!])!
        
        switch command {
            case "forward":
                position.Horizontal += argument
                position.Depth += position.Aim * argument
            case "up":
                position.Aim -= argument
            case "down":
                position.Aim += argument
            default:
                continue
        }
    }
    
    print (position)
    print (position.Horizontal * position.Depth)
}
