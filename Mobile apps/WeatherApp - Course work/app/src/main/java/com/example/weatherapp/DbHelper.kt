package com.example.weatherapp

import android.annotation.SuppressLint
import android.content.ContentValues
import android.content.Context
import android.database.SQLException
import android.database.sqlite.SQLiteDatabase
import android.database.sqlite.SQLiteOpenHelper
import android.util.Log
import android.widget.Toast

class DbHelper(context: Context):SQLiteOpenHelper(context,DATABASE_NAME,null,DATABASE_VERSION) {
    companion object {
        private const val DATABASE_VERSION = 1
        private const val DATABASE_NAME = "WeatherAppDb"
        private val weatherTable="WEATHER"
        private val locationId="ID"
        private val city="CITY"
        private val country="COUNTRY"
        private val lat="LAT"
        private val lon="LON"
        private val currentTime="CURRENT_TIME"
        private val temp="Temp"
        private val feelsLike="FEELS_LIKE"
        private val pressure="PRESSURE"
        private val humidity="HUMIDITY"
        private val clouds="CLOUDS"
        private val visibility="VISIBILITY"
        private val windSpeed="WIND_SPEED"
        private val snow="SNOW"
        private val rain="RAIN"
        private val description="DESCRIPTION"

        private val pollutionTable="POLLUTION"


    }
    override fun onCreate(p0: SQLiteDatabase?) {
        val createLocationTable=("CREATE TABLE $weatherTable(" +
                "$locationId INTEGER PRIMARY KEY AUTOINCREMENT," +
                "$city TEXT NOT NULL," +
                "$country TEXT NOT NULL," +
                "$lat REAL NOT NULL," +
                "$lon REAL NOT NULL," +
                "$currentTime TEXT NOT NULL," +
                "$temp INTEGER NOT NULL," +
                "$feelsLike INTEGER NOT NULL," +
                "$pressure INTEGER NOT NULL," +
                "$humidity INTEGER NOT NULL," +
                "$clouds INTEGER," +
                "$visibility INTEGER," +
                "$windSpeed REAL," +
                "$snow REAL,"+
                "$rain REAL," +
                "$description TEXT)")

        p0?.execSQL(createLocationTable)

    }

    override fun onUpgrade(p0: SQLiteDatabase?, p1: Int, p2: Int) {
        p0?.execSQL("DROP TABLE IF EXISTS $weatherTable")
        p0?.execSQL("DROP TABLE IF EXISTS $pollutionTable")
        onCreate(p0)
    }

    fun insertWeather(weather:Weather):Long{
        val db=this.writableDatabase
        val contVal=ContentValues()
        contVal.put(city,weather.City)
        contVal.put(country,weather.Country)
        contVal.put(lat,weather.Lat)
        contVal.put(lon,weather.Lon)
        contVal.put(currentTime,weather.CurrentTime)
        contVal.put(temp,weather.Temp)
        contVal.put(feelsLike,weather.FeelsLike)
        contVal.put(pressure,weather.Pressure)
        contVal.put(humidity,weather.Humidity)
        contVal.put(clouds,weather.Clouds)
        contVal.put(visibility,weather.Visibility)
        contVal.put(windSpeed,weather.WindSpeed)
        contVal.put(snow,weather.Snow)
        contVal.put(rain,weather.Rain)
        contVal.put(description,weather.Description)
        val result = db.insert(weatherTable, null, contVal)
        return result
    }
    @SuppressLint("Range")
    fun getAllWeathers():ArrayList<Weather>{
        val result=ArrayList<Weather>()
        val db = this.readableDatabase
        val query = "SELECT * FROM $weatherTable"
        val cursor = db.rawQuery(query, null)

        if (cursor.moveToFirst()) {
            do {
                var w = Weather()
                w.ID = cursor.getString(cursor.getColumnIndex(locationId)).toInt()
                w.City= cursor.getString(cursor.getColumnIndex(city))
                w.Country = cursor.getString(cursor.getColumnIndex(country))
                w.Lat = cursor.getString(cursor.getColumnIndex(lat)).toDouble()
                w.Lon = cursor.getString(cursor.getColumnIndex(lon)).toDouble()
                w.CurrentTime = cursor.getString(cursor.getColumnIndex(currentTime))
                w.Temp = cursor.getString(cursor.getColumnIndex(temp)).toInt()
                w.FeelsLike = cursor.getString(cursor.getColumnIndex(feelsLike)).toInt()
                w.Pressure = cursor.getString(cursor.getColumnIndex(pressure)).toInt()
                w.Humidity = cursor.getString(cursor.getColumnIndex(humidity)).toInt()
                w.Clouds = cursor.getString(cursor.getColumnIndex(clouds)).toInt()
                w.Visibility = cursor.getString(cursor.getColumnIndex(visibility)).toInt()
                w.WindSpeed = cursor.getString(cursor.getColumnIndex(windSpeed)).toDouble()
                w.Snow = cursor.getString(cursor.getColumnIndex(snow)).toDouble()
                w.Rain = cursor.getString(cursor.getColumnIndex(rain)).toDouble()
                w.Description = cursor.getString(cursor.getColumnIndex(description))

                result.add(w)
            } while (cursor.moveToNext())
        }
        cursor.close()
        db.close()
        return result;
    }
    @SuppressLint("Range")
    fun getWeather(id:Int):Weather{
        val db = this.readableDatabase
        val cursor = db.query(
            "WEATHER", null, "id = ?",
            arrayOf(id.toString()), null, null, null, "1"
        )

        var result=Weather()
        if (cursor.moveToFirst()) {
            result.ID = cursor.getString(cursor.getColumnIndex(locationId)).toInt()
            result.City= cursor.getString(cursor.getColumnIndex(city))
            result.Country = cursor.getString(cursor.getColumnIndex(country))
            result.Lat = cursor.getString(cursor.getColumnIndex(lat)).toDouble()
            result.Lon = cursor.getString(cursor.getColumnIndex(lon)).toDouble()
            result.CurrentTime = cursor.getString(cursor.getColumnIndex(currentTime))
            result.Temp = cursor.getString(cursor.getColumnIndex(temp)).toInt()
            result.FeelsLike = cursor.getString(cursor.getColumnIndex(feelsLike)).toInt()
            result.Pressure = cursor.getString(cursor.getColumnIndex(pressure)).toInt()
            result.Humidity = cursor.getString(cursor.getColumnIndex(humidity)).toInt()
            result.Clouds = cursor.getString(cursor.getColumnIndex(clouds)).toInt()
            result.Visibility = cursor.getString(cursor.getColumnIndex(visibility)).toInt()
            result.WindSpeed = cursor.getString(cursor.getColumnIndex(windSpeed)).toDouble()
            result.Snow = cursor.getString(cursor.getColumnIndex(snow)).toDouble()
            result.Rain = cursor.getString(cursor.getColumnIndex(rain)).toDouble()
            result.Description = cursor.getString(cursor.getColumnIndex(description))

        }
        cursor.close()
        return result
    }

    fun updateWeather(weather:Weather):Boolean{
        val db = this.writableDatabase
        val contVal = ContentValues()
        contVal.put(city,weather.City)
        contVal.put(country,weather.Country)
        contVal.put(lat,weather.Lat)
        contVal.put(lon,weather.Lon)
        contVal.put(currentTime,weather.CurrentTime)
        contVal.put(temp,weather.Temp)
        contVal.put(feelsLike,weather.FeelsLike)
        contVal.put(pressure,weather.Pressure)
        contVal.put(humidity,weather.Humidity)
        contVal.put(clouds,weather.Clouds)
        contVal.put(visibility,weather.Visibility)
        contVal.put(windSpeed,weather.WindSpeed)
        contVal.put(snow,weather.Snow)
        contVal.put(rain,weather.Rain)
        contVal.put(description,weather.Description)

        try {
            val success =
                db.update(weatherTable, contVal, locationId + "=?", arrayOf(weather.ID.toString()))
            db.close()
            if(success<=0){
                Log.e("Hi","here")
            }
            return success>0

        } catch (e: SQLException) {
            e.printStackTrace()
        }
        return false
    }

    fun deleteWeather(id:Int):Int{
        val db = this.writableDatabase
        val contVal = ContentValues()
        contVal.put(locationId, id)
        val result = db.delete(weatherTable, "$locationId=$id", null)
        db.close()
        return result
    }

}