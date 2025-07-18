package com.example.weatherapp

import android.annotation.SuppressLint
import android.content.Intent
import android.os.Build
import android.os.Bundle
import android.util.Log
import android.view.Gravity
import android.view.View
import android.widget.Button
import android.widget.ImageButton
import android.widget.TableLayout
import android.widget.TableRow
import android.widget.TextView
import android.widget.Toast
import androidx.activity.ComponentActivity
import androidx.annotation.RequiresApi
import androidx.core.content.ContextCompat

class HistoryActivity:ComponentActivity() {
    private lateinit var editImg:ImageButton
    private lateinit var deleteImg:ImageButton
    private lateinit var tableLayout:TableLayout
    private lateinit var tr_header:TableRow
    val db=DbHelper(this)


    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.history_activity)
        tableLayout=findViewById<TableLayout>(R.id.table_layout)
        tr_header=findViewById<TableRow>(R.id.tr_header)
        val btn_back=findViewById<Button>(R.id.btn_back)
        insertData()


        btn_back.setOnClickListener {
            val intent = Intent(this, MainActivity::class.java)
            try {
                startActivity(intent)
                finish()
            } catch (e: Exception) {
                e.printStackTrace()
            }
        }


    }
    fun editRecord(){
        if(CONSTANTS.currentCheck!=-1){
            Toast.makeText(this,"Преминаваме в режим на редакция", Toast.LENGTH_SHORT).show()
            val intent = Intent(this,EditWeatherActivity::class.java)
            try {
                startActivity(intent)
                finish()

            } catch (e: Exception) {

                e.printStackTrace()
            }
        }else{
            Toast.makeText(this,"Грешка при избор на редакция", Toast.LENGTH_SHORT).show()
        }

    }
    fun deleteRecord(){
        Log.d("Hi","Clicked")
        if(CONSTANTS.currentCheck!=-1){
            val res=db.deleteWeather(CONSTANTS.currentCheck)
            if(res!=0) {
                Toast.makeText(this, "Записът беше изтрит успешно!", Toast.LENGTH_SHORT).show()
                insertData()
            }else{
                Toast.makeText(this,"Възникна грешка при изтриване на записа - с id", Toast.LENGTH_SHORT).show()
            }
        }else{
            Toast.makeText(this,"Възникна грешка при изтриване на записа- без id", Toast.LENGTH_SHORT).show()
        }
    }


    @SuppressLint("ResourceAsColor")
    fun insertData() {
        val historyRecord = db.getAllWeathers()
        tableLayout.removeAllViews()
        tableLayout.addView(tr_header)
        if (historyRecord == null) {
            Toast.makeText(this,"Все още не сте добавили нищо",Toast.LENGTH_SHORT).show()
        } else {
            for (i in historyRecord) {
                val row = TableRow(this)

                val cityTV = TextView(this)
                cityTV.text = i.City
                cityTV.setTextColor(ContextCompat.getColor(this, R.color.white))
                cityTV.layoutParams = TableRow.LayoutParams(
                    90,
                    100
                )
                cityTV.gravity = Gravity.CENTER

                val dateTV = TextView(this)
                dateTV.text = i.CurrentTime
                dateTV.setTextColor(ContextCompat.getColor(this, R.color.white))
                dateTV.layoutParams = TableRow.LayoutParams(
                    80,
                    100
                )
                dateTV.gravity = Gravity.CENTER

                val tempTV = TextView(this)
                tempTV.text = i.Temp.toString() + '\u2103'
                tempTV.setTextColor(ContextCompat.getColor(this, R.color.white))
                tempTV.layoutParams = TableRow.LayoutParams(
                    70,
                    100
                )
                tempTV.gravity = Gravity.CENTER


                editImg = ImageButton(this)
                editImg.contentDescription = "Редактирай"
                editImg.setImageResource(R.drawable.edit)
                editImg.layoutParams = TableRow.LayoutParams(
                    90,
                    100
                )
                editImg.setOnClickListener {
                    CONSTANTS.currentCheck = i.ID
                    editRecord()
                }

                deleteImg = ImageButton(this)
                deleteImg.contentDescription = "Изтрий"
                deleteImg.setImageResource(R.drawable.delete)
                deleteImg.layoutParams = TableRow.LayoutParams(
                    90,
                    100
                )
                deleteImg.setOnClickListener {
                    CONSTANTS.currentCheck = i.ID
                    deleteRecord()
                }


                row.addView(cityTV)
                row.addView(dateTV)
                row.addView(tempTV)
                row.addView(editImg)
                row.addView(deleteImg)
                tableLayout.addView(row)

            }

        }

    }
}