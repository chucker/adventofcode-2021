//
//  main.swift
//  adventofcode-2021-day-1
//
//  Created by Sören Kuklau on 01.12.21.
//

import Foundation

let content = try? String(contentsOfFile: "input.txt")

var count = 0

var previousMeasurement : Int32?
for line in content!.split(whereSeparator: \.isNewline) {
    let currentMeasurement = Int32(line)!

    if previousMeasurement == nil {
        previousMeasurement = currentMeasurement
    }

    if currentMeasurement > previousMeasurement! {
        count += 1
    }
    
    previousMeasurement = currentMeasurement
}

print (count)
