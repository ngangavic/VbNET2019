package com.example.ngangavictor.smartforex;

import android.os.Bundle;
import android.support.v7.app.AppCompatActivity;
import android.support.v7.widget.Toolbar;
import android.view.Menu;
import android.view.MenuItem;
import android.view.View;
import android.widget.LinearLayout;

public class SendMoneyActivity extends AppCompatActivity {
    private LinearLayout mLayoutDestination;
    private LinearLayout mLayoutPhone;
    private LinearLayout mLayoutBank;
    private LinearLayout mLayoutSendVia;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_send_money);
        Toolbar toolbar = findViewById(R.id.toolbar);
        setSupportActionBar(toolbar);
        mLayoutDestination = findViewById(R.id.layoutDestination);
        mLayoutPhone = findViewById(R.id.layoutPhone);
        mLayoutBank = findViewById(R.id.layoutBank);
        mLayoutSendVia = findViewById(R.id.layoutSendVia);

        mLayoutPhone.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                mLayoutDestination.setVisibility(View.GONE);
                mLayoutSendVia.setVisibility(View.VISIBLE);
            }
        });

        mLayoutBank.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                mLayoutDestination.setVisibility(View.GONE);
                mLayoutSendVia.setVisibility(View.VISIBLE);
            }
        });

    }

    @Override
    public boolean onCreateOptionsMenu(Menu menu) {
        // Inflate the menu; this adds items to the action bar if it is present.
        getMenuInflater().inflate(R.menu.home, menu);
        return true;
    }

    @Override
    public boolean onOptionsItemSelected(MenuItem item) {
        // Handle action bar item clicks here. The action bar will
        // automatically handle clicks on the Home/Up button, so long
        // as you specify a parent activity in AndroidManifest.xml.
        int id = item.getItemId();

        //noinspection SimplifiableIfStatement
        if (id == R.id.action_chat) {
            return true;
        }

        return super.onOptionsItemSelected(item);
    }

}
