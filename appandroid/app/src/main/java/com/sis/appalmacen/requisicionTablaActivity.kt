package com.sis.appalmacen

import android.content.Intent
import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.widget.Button

class requisicionTablaActivity : AppCompatActivity() {
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_requisicion_tabla)

        val botonAgrega = findViewById<Button>(R.id.btnAgregar)
        val botonMenu = findViewById<Button>(R.id.btnMenu)


        botonAgrega.setOnClickListener {
            val intento1 = Intent(this, requisicionActivity::class.java)
            startActivity(intento1)
        }

        botonMenu.setOnClickListener {
            finish()
        }


    }
}