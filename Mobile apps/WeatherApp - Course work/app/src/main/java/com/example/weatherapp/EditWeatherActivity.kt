package com.example.weatherapp

import android.content.Intent
import android.os.Bundle
import android.widget.Button
import android.widget.ImageView
import android.widget.TextView
import android.widget.Toast
import androidx.appcompat.app.AppCompatActivity

class EditWeatherActivity:AppCompatActivity() {
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.edit_weather_activity)
        val et_city = findViewById<TextView>(R.id.et_city)
        val et_country = findViewById<TextView>(R.id.et_country)
        val et_time = findViewById<TextView>(R.id.et_date)
        val et_temp = findViewById<TextView>(R.id.et_temp)
        val et_feels_like = findViewById<TextView>(R.id.et_feels_like)
        val et_description = findViewById<TextView>(R.id.et_description)
        val et_pressure = findViewById<TextView>(R.id.et_pressure)
        val et_humidity = findViewById<TextView>(R.id.et_humidity)
        val et_clouds = findViewById<TextView>(R.id.et_cloud)
        val et_wind_speed = findViewById<TextView>(R.id.et_wind_speed)
        val et_snow = findViewById<TextView>(R.id.et_snow)
        val et_rain = findViewById<TextView>(R.id.et_rain)
        val btn_history = findViewById<Button>(R.id.btn_history)
        val btn_save = findViewById<Button>(R.id.btn_save)
        val btn_delete = findViewById<Button>(R.id.btn_delete)
        val btn_back = findViewById<Button>(R.id.btn_back)
        val db = DbHelper(this)

        val result=db.getWeather(CONSTANTS.currentCheck)
        if(result!=null){
            et_city.text=result.City
            et_country.text=result.Country
            et_time.text=result.CurrentTime
            et_temp.text=result.Temp.toString()
            et_feels_like.text=result.FeelsLike.toString()
            et_description.text=result.Description
            et_pressure.text=result.Pressure.toString()
            et_humidity.text=result.Humidity.toString()
            et_clouds.text=result.Clouds.toString()
            et_wind_speed.text=result.WindSpeed.toString()
            et_snow.text=result.Snow.toString()
            et_rain.text=result.Rain.toString()
        }else{
            val intent = Intent(this, HistoryActivity::class.java)
            Toast.makeText(HistoryActivity(),"Грешка при стартиране на действията",Toast.LENGTH_SHORT).show()
            try {
                startActivity(intent)
                finish()
            } catch (e: Exception) {
                e.printStackTrace()
            }
        }

        btn_save.setOnClickListener{
            if(regNumber(et_temp.text.toString()) &&
                regNumber(et_feels_like.text.toString()) &&
                regNumber(et_pressure.text.toString()) &&
                regNumber(et_humidity.text.toString()) &&
                regNumber(et_clouds.text.toString()) &&
                regNumber(et_wind_speed.text.toString()) &&
                regNumber(et_snow.text.toString()) &&
                regNumber(et_rain.text.toString())) {

                val weather = Weather()
                weather.ID = CONSTANTS.currentCheck
                weather.City = et_city.text.toString()
                weather.Country = et_country.text.toString()
                weather.CurrentTime = et_time.text.toString()
                weather.Description = et_description.text.toString()
                weather.Temp = et_temp.text.toString().toInt()
                weather.FeelsLike = et_feels_like.text.toString().toInt()
                weather.Pressure = et_pressure.text.toString().toInt()
                weather.Humidity = et_humidity.text.toString().toInt()
                weather.Clouds = et_clouds.text.toString().toInt()
                weather.WindSpeed = et_wind_speed.text.toString().toDouble()
                weather.Snow = et_snow.text.toString().toDouble()
                weather.Rain = et_rain.text.toString().toDouble()

                val res = db.updateWeather(weather)
                if (res == true) {

                    val intent = Intent(this, HistoryActivity::class.java)
                    try {
                        startActivity(intent)
                        Toast.makeText(this, "Промените бяха запазени", Toast.LENGTH_SHORT).show()
                        finish()
                    } catch (e: Exception) {
                        e.printStackTrace()
                    }
                } else {
                    Toast.makeText(
                        this,
                        "Възникна грешка при запазване на данните",
                        Toast.LENGTH_SHORT
                    ).show()
                }
            }else{
                Toast.makeText(this,"Невалидни данни, моля попълнете отново!",Toast.LENGTH_SHORT).show()
            }
        }

        btn_history.setOnClickListener{
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

        btn_delete.setOnClickListener{
            if(CONSTANTS.currentCheck!=-1){
                val res=db.deleteWeather(CONSTANTS.currentCheck)
                if(res!=0) {
                    Toast.makeText(this, "Записът беше изтрит успешно!", Toast.LENGTH_SHORT).show()
                    val intent = Intent(this, HistoryActivity::class.java)
                    try {
                        startActivity(intent)
                        finish()
                    } catch (e: Exception) {
                        e.printStackTrace()
                    }
                }else{
                    Toast.makeText(this,"Възникна грешка при изтриване на записа - с id", Toast.LENGTH_SHORT).show()
                }
            }else{
                Toast.makeText(this,"Възникна грешка при изтриване на записа- без id", Toast.LENGTH_SHORT).show()
            }
        }
    }
    fun regNumber(s:String): Boolean {
        val pattern = """^-?\d+(\.\d+)?${'$'}?""".toRegex()
        return pattern.matches(s)
    }
}