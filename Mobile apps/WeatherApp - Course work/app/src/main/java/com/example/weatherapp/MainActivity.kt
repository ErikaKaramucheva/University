package com.example.weatherapp

import android.annotation.SuppressLint
import android.content.Intent
import android.content.pm.PackageManager
import android.os.AsyncTask
import android.os.Bundle
import android.util.Log
import android.widget.Button
import android.widget.TextView
import android.widget.Toast
import androidx.activity.ComponentActivity
import com.example.weatherapp.CONSTANTS.msg
import com.example.weatherapp.databinding.ActivityMainBinding
import com.google.android.gms.location.FusedLocationProviderClient

class MainActivity : ComponentActivity() {

    @SuppressLint("SetTextI18n")
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_main)
        if(CONSTANTS.msg!=""){
            Toast.makeText(this,msg,Toast.LENGTH_SHORT).show()
            CONSTANTS.msg=""
        }

        val et_name = findViewById<TextView>(R.id.et_name)
        val btn_start = findViewById<Button>(R.id.btn_start)
        val btn_history = findViewById<Button>(R.id.btn_history)


        btn_start.setOnClickListener {
            if (et_name.text.toString().isEmpty() || isValidCity(et_name.text.toString())) {
                Toast.makeText(this, "Моля, въведете валидно име на града", Toast.LENGTH_SHORT)
                    .show()
            } else {
                val intent = Intent(this, CurrentWeatherActivity::class.java)
                CONSTANTS.CITY=et_name.text.toString()
                intent.putExtra(

                    CONSTANTS.CITY,
                    et_name.text.toString()

                )
                try {
                    startActivity(intent)
                    finish()

                } catch (e: Exception) {

                    e.printStackTrace()
                }
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

    }
}
    fun isValidCity(cityName: String): Boolean {
        val pattern = """^[a-zA-Z]+(?:[ -][a-zA-Z]+)*$""".toRegex()
        return pattern.matches(cityName)
    }



