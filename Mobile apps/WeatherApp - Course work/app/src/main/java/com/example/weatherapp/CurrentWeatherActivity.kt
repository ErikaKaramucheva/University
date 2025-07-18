package com.example.weatherapp

import android.annotation.SuppressLint
import android.content.Intent
import android.os.Build
import android.os.Bundle
import android.util.Log
import android.widget.Button
import android.widget.ImageView
import android.widget.TextView
import android.widget.Toast
import androidx.activity.ComponentActivity
import androidx.annotation.RequiresApi
import java.time.LocalDateTime

class CurrentWeatherActivity:ComponentActivity() {



    @SuppressLint("SetTextI18n")
    @RequiresApi(Build.VERSION_CODES.O)
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.current_weather_activity)
        val tv_city = findViewById<TextView>(R.id.tv_city)
        val tv_time = findViewById<TextView>(R.id.tv_time)
        val iv_img = findViewById<ImageView>(R.id.iv_img)
        val tv_temp = findViewById<TextView>(R.id.tv_temp)
        val tv_feels_like = findViewById<TextView>(R.id.tv_feels_like)
        val tv_description = findViewById<TextView>(R.id.tv_description)
        val tv_pressure = findViewById<TextView>(R.id.tv_pressure)
        val tv_humidity = findViewById<TextView>(R.id.tv_humidity)
        val tv_clouds = findViewById<TextView>(R.id.tv_clouds)
        val tv_wind_speed = findViewById<TextView>(R.id.tv_wind_speed)
        val tv_snow = findViewById<TextView>(R.id.tv_snow)
        val tv_rain = findViewById<TextView>(R.id.tv_rain)
        val btn_history = findViewById<Button>(R.id.btn_history)
        val btn_back = findViewById<Button>(R.id.btn_back)
        val wService = WeatherService()
        val db=DbHelper(this)

        wService.getInfo(CONSTANTS.CITY) { weather, exception ->
            if (weather != null) {

                runOnUiThread {
                    tv_city.text=weather.City + ", " + weather.Country
                    tv_time.text=weather.CurrentTime
                    tv_temp.text = weather.Temp.toString()+'\u2103'
                    tv_feels_like.text = weather.FeelsLike.toString()+'\u2103'
                    tv_description.setText(weather.Description)
                    tv_pressure.setText(weather.Pressure.toString()+"hPa")
                    tv_humidity.setText(weather.Humidity.toString()+"%")
                    tv_clouds.setText(weather.Clouds.toString()+"%")
                    tv_wind_speed.setText(weather.WindSpeed.toString()+"m/s")
                    tv_snow.setText(weather.Snow.toString()+"mm.")
                    tv_rain.setText(weather.Rain.toString()+"mm.")

                    if(weather.Description.contains("sun")){
                        iv_img.setImageResource(R.drawable.sunny)
                    }else if(weather.Description.contains("partly cloudy")){
                        iv_img.setImageResource(R.drawable.partly)
                    }else if(weather.Description.contains("cloud")){
                    iv_img.setImageResource(R.drawable.clouds)
                }else if(weather.Description.contains("rain")){
                        iv_img.setImageResource(R.drawable.rainy)
                    }else if(weather.Description.contains("snow")){
                        iv_img.setImageResource(R.drawable.snow)
                    }else{
                        iv_img.setImageResource(R.drawable.weather)
                    }
                }

                Log.e("success", "success")
            } else if (exception != null) {
                CONSTANTS.msg= "Грешка при извличането на данните"
                Log.e("ele if", "else if")
                val intent = Intent(this, MainActivity::class.java)
                try {
                    startActivity(intent)
                   finish()
                } catch (e: Exception) {
                    e.printStackTrace()
                }
                exception.printStackTrace()
            } else {
                CONSTANTS.msg= "Грешка при извличането на данните"
                Log.e("else", "else")
                val intent = Intent(this, MainActivity::class.java)
                try {
                    startActivity(intent)
                    finish()
                } catch (e: Exception) {
                    e.printStackTrace()
                }

            }

        }
        val btn_save=findViewById<Button>(R.id.btn_save)
        btn_save.setOnClickListener {
            val success = db.insertWeather(CONSTANTS.Weather)
            if (success!=-1L){
                Toast.makeText(this,"Успешно запазени данни",Toast.LENGTH_SHORT).show()
        }else{
                Toast.makeText(this,"Възникна грешка при запазването на  данните",Toast.LENGTH_SHORT).show()
            }
    }

        btn_history.setOnClickListener {
            val intent = Intent(this, HistoryActivity::class.java)
            try {
                startActivity(intent)
                finish()
            } catch (e: Exception) {
                e.printStackTrace()
            }
        }

        btn_back.setOnClickListener {
            val intent = Intent(this, MainActivity::class.java)
            try {
                startActivity(intent)
                finish()
            } catch (e: Exception) {
                e.printStackTrace()
            }
        }

}}