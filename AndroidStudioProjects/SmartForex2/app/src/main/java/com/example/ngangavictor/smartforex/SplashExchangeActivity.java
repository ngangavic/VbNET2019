package com.example.ngangavictor.smartforex;

import android.content.Intent;
import android.content.pm.ActivityInfo;
import android.os.Bundle;
import android.os.Handler;
import android.support.v7.app.ActionBar;
import android.support.v7.app.AppCompatActivity;
import android.view.Window;
import android.view.WindowManager;

public class SplashExchangeActivity extends AppCompatActivity {
    private static final String TAG = MainActivity.class.getSimpleName();
    private final int SPLASH_DISPLAY_LENGTH = 3000;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        requestWindowFeature(Window.FEATURE_NO_TITLE);
        getWindow().setFlags(WindowManager.LayoutParams.FLAG_FULLSCREEN, WindowManager.LayoutParams.FLAG_FULLSCREEN);
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_splash_exchange);
        setRequestedOrientation(ActivityInfo.SCREEN_ORIENTATION_PORTRAIT);
        ActionBar actionBar = getSupportActionBar();
        if(null != actionBar){
            actionBar.hide();
        }new Handler().postDelayed(new Runnable(){
            @Override
            public void run(){
                Intent startActivityIntent = new Intent(SplashExchangeActivity.this, StartActivity.class);
                startActivity(startActivityIntent);
                finish();

            }
        }, SPLASH_DISPLAY_LENGTH);
    }
    }