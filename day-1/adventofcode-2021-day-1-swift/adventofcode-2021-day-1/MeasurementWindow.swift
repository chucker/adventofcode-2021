//
//  MeasurementWindow.swift
//  adventofcode-2021-day-1
//
//  Created by Sören Kuklau on 01.12.21.
//

import Foundation

class MeasurementWindow {
    var Values : [Int] = []

    func addValue(newValue : Int) {
        while Values.count >= 3 {
            Values.remove(at: 0)
        }
        
        Values.append(newValue)
    }
}
