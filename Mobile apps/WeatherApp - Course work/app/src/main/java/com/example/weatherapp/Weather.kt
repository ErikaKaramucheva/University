package com.example.weatherapp

import java.sql.Date

data class Weather (
    var ID:Int,
    var City:String,
    var Country:String,
    var Lat:Double,
    var Lon:Double,
    var CurrentTime:String,
    var Temp:Int,
    var FeelsLike:Int,
    var Pressure:Int,
    var Humidity:Int,
    var Clouds:Int,
    var Visibility:Int,
    var WindSpeed:Double,
    var Snow:Double,
    var Rain:Double,
    var Description:String
) {
    constructor():
            this(0,"","",0.0,0.0,
                "",0,0,
                0,0,0,0,0.0,
                0.0,0.0,"")
}
