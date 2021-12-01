//
//  main.swift
//  adventofcode-2021-day-1
//
//  Created by Sören Kuklau on 01.12.21.
//

import Foundation

let content = try? String(contentsOfFile: "input.txt")

var count = 0

var previousSum = 0
var window = MeasurementWindow()
for line in content!.split(whereSeparator: \.isNewline) {
    let currentMeasurement = Int(line)!

    window.addValue(newValue: currentMeasurement)
    
    print("window is now \(window.Values)")
    
    if (window.Values.count < 3) {
        continue;
    }
    
    let newSum = window.Values.reduce(0, +)
    
    if previousSum > 0 && newSum > previousSum {
        print("previousSum was \(previousSum), newSum is \(newSum)")
        count += 1
    }
    
    previousSum = newSum
}

print(count)
