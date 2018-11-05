
//we can set animation delay as following in ms (default 1000)
ProgressBar.singleStepAnimation = 1500;
ProgressBar.init(
  [ 'SPECS',
    'Production',
    'Testing',
    'Shipping',
    'Received',
  ],
  'SPECS',
  'progress-bar-wrapper' // created this optional parameter for container name (otherwise default container created)
);