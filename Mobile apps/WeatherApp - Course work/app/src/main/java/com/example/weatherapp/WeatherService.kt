package com.example.weatherapp

import android.os.Build
import android.util.Log
import android.widget.Toast
import androidx.annotation.RequiresApi
import okhttp3.Call
import okhttp3.Callback
import okhttp3.OkHttpClient
import okhttp3.Request
import okhttp3.Response
import org.json.JSONObject
import java.time.LocalDate
import java.time.LocalDateTime
import java.time.format.DateTimeFormatter
import kotlin.math.roundToInt

public class WeatherService() {
    val apiKey = "e946c821be886e6b1e67031ee59639df"
    private val client = OkHttpClient()


    fun getInfo(city: String, callback: (Weather?, Exception?) -> Unit) {
        val apiUrl = "https://api.openweathermap.org/data/2.5/weather?q=$city&appid=$apiKey"
        val request = Request.Builder().url(apiUrl).build()

        client.newCall(request).enqueue(object : Callback {
            override fun onFailure(call: Call, e: java.io.IOException) {
                callback(null, e)
            }

            @RequiresApi(Build.VERSION_CODES.O)
            override fun onResponse(call: Call, response: Response) {
                if (response.isSuccessful) {
                    try {
                        val weatherData = JSONObject(response.body?.string())
                        val weather = parseWeatherData(weatherData)
                        callback(weather, null)
                    } catch (e: Exception) {
                        callback(null, e)
                    }
                } else {
                    callback(null, WeatherServiceException(response.code))
                }
            }


        })
    }
    @RequiresApi(Build.VERSION_CODES.O)
    private fun parseWeatherData(weatherData: JSONObject): Weather {
        val weather = Weather()
        val lat = weatherData.getJSONObject("coord").getDouble("lat")
        val lon = weatherData.getJSONObject("coord").getDouble("lon")
        var temperature = weatherData.getJSONObject("main").getInt("temp")
        var feels_like = weatherData.getJSONObject("main").getInt("feels_like")
        val pressure = weatherData.getJSONObject("main").getInt("pressure")
        val humidity = weatherData.getJSONObject("main").getInt("humidity")
        val rain = weatherData.optJSONObject("rain")?.getDouble("1h") ?: 0.0
        val snow = weatherData.optJSONObject("snow")?.getDouble("1h") ?: 0.0
        val clouds = weatherData.optJSONObject("clouds")?.getInt("all") ?: 0
        val wind = weatherData.optJSONObject("wind")?.getDouble("speed") ?: 0.0
       val country= weatherData.optJSONObject("sys").getString("country")
        val weatherDescription =
            weatherData.getJSONArray("weather").getJSONObject(0).getString("description")
        val currentTime= LocalDateTime.now()
        val formatter = DateTimeFormatter.ofPattern("HH:mm dd-MM-yyyy")
        val time=currentTime.format(formatter)
       temperature=(temperature-273.15).toInt()
        feels_like=(feels_like-273.15).toInt()


        weather.City= CONSTANTS.CITY
        weather.Country=country
        weather.Temp = temperature
        weather.Description = weatherDescription
        weather.Lat = lat
        weather.Lon = lon
        weather.FeelsLike = feels_like
        weather.Pressure = pressure
        weather.Snow = snow
        weather.Humidity = humidity
        weather.Rain = rain
        weather.CurrentTime= time.toString()
        weather.Clouds=clouds
        weather.WindSpeed=wind

        CONSTANTS.Weather=weather
        return weather
    }

}

class WeatherServiceException(val code: Int) : Exception("Weather service error: $code")

