package com.example.ngangavictor.smartforex;

import android.content.Intent;
import android.os.Bundle;
import android.support.v7.app.AppCompatActivity;
import android.support.v7.widget.Toolbar;
import android.view.Menu;
import android.view.MenuItem;
import android.view.View;
import android.widget.LinearLayout;

public class PayBillsActivity extends AppCompatActivity {
    private LinearLayout mLayoutCreditBundles;
    private LinearLayout mLayoutPayUtilityBills;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_pay_bills);
        Toolbar toolbar = findViewById(R.id.toolbar);
        setSupportActionBar(toolbar);
        mLayoutCreditBundles = findViewById(R.id.layoutCreditBundles);
        mLayoutPayUtilityBills = findViewById(R.id.layoutPayUtilityBills);
        mLayoutCreditBundles.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                Intent intent = new Intent(PayBillsActivity.this,CreditBundlesActivity.class);
            }
        });

        mLayoutPayUtilityBills.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {

            }
        });

    }

    @Override
    public boolean onCreateOptionsMenu(Menu menu) {
        getMenuInflater().inflate(R.menu.home, menu);
        return true;
    }

    @Override
    public boolean onOptionsItemSelected(MenuItem item) {
        int id = item.getItemId();

        //noinspection SimplifiableIfStatement
        if (id == R.id.action_chat) {
            return true;
        }
        return super.onOptionsItemSelected(item);
    }
}
