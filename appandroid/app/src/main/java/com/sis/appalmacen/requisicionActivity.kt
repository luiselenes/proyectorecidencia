package com.sis.appalmacen

import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.widget.Button
import android.widget.EditText
import android.widget.TableLayout

class requisicionActivity : AppCompatActivity() {


    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_requisicion)

        val botonretroceso = findViewById<Button>(R.id.buttonAtras)

        botonretroceso.setOnClickListener {
            finish()
        }


    }
}